﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class UserController : Controller
    {
        private IWorkerService _workerService;
        private IGenderDal _genderDal;
        private ICityService _cityService;
        private IAuthService _authService;
        private IUserService _userService;


        public UserController(IUserService userService, IWorkerService workerService, IGenderDal genderDal, ICityService cityService, IUserRoleDal userRoleDal, IUserDal userDal, IAuthService authService)
        {
            _userService = userService;
            _workerService = workerService;
            _genderDal = genderDal;
            _cityService = cityService;
            _authService = authService;
        }

        public IActionResult Index()
        {
            var result = _workerService.GetAllManagers();
            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }
            var model = new ManagerListViewModel
            {
                Managers = result.Data
            };
            return View(model);
        }

        public IActionResult Worker()
        {
            var result = _workerService.GetWorkers();
            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }
            var model = new WorkerListViewModel
            {
                Workers = result.Data
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult AddManager()
        {
            var model = new AddManagerViewModel
            {
                AddWorkerDto = new AddWorkerDto(),
                GenderNamesSelectItems = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Cinsiyet",Value = "0"}
                }
            };
            foreach (var gender in _genderDal.GetList())
            {
                model.GenderNamesSelectItems.Add(new SelectListItem
                {
                    Text = gender.GenderName,
                    Value = gender.GenderId.ToString()
                });
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult AddManager(AddWorkerDto addWorkerDto)
        {
            var model = new AddManagerViewModel
            {
                AddWorkerDto = addWorkerDto,
                GenderNamesSelectItems = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Cinsiyet",Value = "0"}
                }

            };
            foreach (var gender in _genderDal.GetList())
            {
                model.GenderNamesSelectItems.Add(new SelectListItem
                {
                    Text = gender.GenderName,
                    Value = gender.GenderId.ToString()
                });
            }
            if (addWorkerDto.GenderId == 0)
            {
                TempData.Add(TempDataTypes.GenderError, Messages.MustBeFilled);

                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userForRegister = new UserForRegisterDto
            {
                Email = addWorkerDto.Email,
                GenderId = addWorkerDto.GenderId,
                LastName = addWorkerDto.LastName,
                FirstName = addWorkerDto.FirstName,
                Password = addWorkerDto.Password,
                PhoneNumber = addWorkerDto.PhoneNumber
            };

            var result = _authService.Register(userForRegister, userForRegister.Password);

            if (!result.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result.Message });
            }

            var user = _userService.GetByMail(addWorkerDto.Email).Data;
            var worker = new Worker
            {
                AddressNumber = addWorkerDto.AddressNumber,
                IdentityNo = addWorkerDto.IdentityNo,
                Street = addWorkerDto.Street,
                CityId = addWorkerDto.CityId,
                DistrictId = addWorkerDto.DistrictId,
                BirthDate = new DateTime(Convert.ToInt32(addWorkerDto.BirthDateYear), Convert.ToInt32(addWorkerDto.BirthDateMounth), Convert.ToInt32(addWorkerDto.BirthDateDay),0,0,0),
                WorkerId = user.Id
            };

            var result2 = _workerService.AddManager(worker);

            if (!result2.Success)
            {
                return RedirectToAction("InternalError", "Error", new { errorMessage = result2.Message });
            }

            TempData.Add(TempDataTypes.ManageInfo,Messages.ManagerAddedSuccessfully);
            return RedirectToAction("Index", "User");
        }

        [HttpPost]
        public ActionResult GetDistricts(int cityId)
        {
            var model = _cityService.GetDistrictsByCityId(cityId).Data;

            //return Ok(model);
            return Json(model);
        }
    }
}