﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        private ISubCategoryDal _subCategoryDal;

        public CategoryManager(ICategoryDal categoryDal, ISubCategoryDal subCategoryDal)
        {
            _categoryDal = categoryDal;
            _subCategoryDal = subCategoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            try
            {
                return new SuccessDataResult<List<Category>>(_categoryDal.GetList());
            }
            catch (Exception)
            {
                return new ErrorDataResult<List<Category>>(Messages.ErrorWhileGettingEntity);
            }
        }

        public IDataResult<List<Category>> GetMainCategories()
        {
            try
            {
                var categories = _categoryDal.GetList(c => c.IsMainCategory == true);
                return new SuccessDataResult<List<Category>>(categories);
            }
            catch (Exception e)
            {
                return new ErrorDataResult<List<Category>>(Messages.ErrorWhileGettingEntity);
            }
        }

        public IDataResult<List<Category>> GetSubCategories(int categoryId)
        {
            if (IsEndCategory(categoryId))
            {
                return new ErrorDataResult<List<Category>>(Messages.ThereIsntSubCategory);
            }

            var subCategories = _subCategoryDal.GetList(sc => sc.CategoryId == categoryId);
            List<Category> categories = new List<Category>();
            foreach (var subCategory in subCategories)
            {
                categories.Add(_categoryDal.Get(c=>c.CategoryId==subCategory.SubCategoryId));
            }
            return new SuccessDataResult<List<Category>>(categories);
        }

        public bool IsEndCategory(int categoryId)
        {
            //var deneme = _subCategoryDal.GetList(sc => sc.CategoryId == categoryId);
            if (_subCategoryDal.GetList(c=>c.CategoryId == categoryId).Count == 0)
            {
                return true;
            }

            return false;
        }

        public IResult AddCategory(Category category, int mainCategoryId = -1)
        {
            if (mainCategoryId == -1)
            {
                try
                {
                    _categoryDal.Add(category);
                    return new SuccessResult();
                }
                catch (Exception)
                {
                   return new ErrorResult(Messages.ErrorWhileAddingEntity);
                }
            }

            try
            {
                _categoryDal.Add(category);
               var addedCategory = _categoryDal.Get(c => c.CategoryName == category.CategoryName);
                var subCategory = new SubCategory
                {
                    CategoryId = mainCategoryId,
                    SubCategoryId = addedCategory.CategoryId
                };
                _subCategoryDal.Add(subCategory);
                return new SuccessResult();
            }
            catch (Exception e)
            {
                return new ErrorResult(Messages.ErrorWhileAddingEntity);
            }

        }

        public IResult DeleteCategory(Category category)
        {
            if (IsEndCategory(category.CategoryId))
            {
                try
                {
                    if (!category.IsMainCategory)
                    {
                        var subCategory = _subCategoryDal.Get(sc => sc.SubCategoryId == category.CategoryId);
                        _subCategoryDal.Delete(subCategory);
                    }
                    _categoryDal.Delete(category);
                    return new SuccessResult();
                }
                catch (Exception)
                {
                    return new ErrorResult(Messages.ErrorWhileDeletingEntity);
                }
            }
            return new ErrorResult(Messages.CategoryCantDeleted);
        }


        public IDataResult<Category> GetMainCategory(int categoryId)
        {
            try
            {
                var mainCategoryId = _subCategoryDal.Get(sc => sc.SubCategoryId == categoryId).CategoryId;
                var mainCategory = _categoryDal.Get(c => c.CategoryId == mainCategoryId);
                return new SuccessDataResult<Category>(mainCategory);
            }
            catch (Exception)
            {
                return new ErrorDataResult<Category>(Messages.ErrorWhileGettingEntity);
            }
        }

        public IDataResult<Category> GetByCategoryId(int categoryId)
        {
            try
            {
                return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
            }
            catch (Exception)
            {
                return new ErrorDataResult<Category>(Messages.ErrorWhileGettingEntity);
            }
        }
    }
}
