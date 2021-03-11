using log4net;
using Microsoft.EntityFrameworkCore;
using OrderSysManagement.Data;
using OrderSysManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderSysManagement.Service
{
    public class ArticleCategoryService
    {
        private readonly IDbContextFactory<OrderDbContext> Provider;
        private ILog Log;
        public ArticleCategoryService(IDbContextFactory<OrderDbContext> provider)
        {
            this.Provider = provider;
            Log = LogManager.GetLogger("ArticleCategoryService");
        }
        public async Task<List<ArticleCategory>> GetCategoriesAsync()
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<ArticleCategory> categories = await orderDbContext.ArticleCategories.AsNoTracking().OrderBy(c => c.Id).ToListAsync();
                    return categories;
                }
                catch
                {
                    return new List<ArticleCategory>();
                }
            }
        }
        public async Task DeleteArticleCategoryById(int id)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    ArticleCategory articleCategory = await orderDbContext.ArticleCategories.Where(a => a.Id == id).AsNoTracking().FirstAsync();
                    orderDbContext.ArticleCategories.Remove(articleCategory);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task MultiDeleteArticleCategoryByIds(List<int> ids)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<ArticleCategory> articleCategories = await orderDbContext.ArticleCategories.Where(a => ids.Contains(a.Id)).AsNoTracking().ToListAsync();
                    orderDbContext.ArticleCategories.RemoveRange(articleCategories);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task<ArticleCategory> GetArticleCategoryByIdAsync(int id)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    ArticleCategory articleCategory = await orderDbContext.ArticleCategories.Where(a => a.Id == id).AsNoTracking().FirstOrDefaultAsync();
                    return articleCategory;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public async Task<ActionResult> InsertArticleCategoryAsync(ArticleCategoryModel articleCategoryModel)
        {
            ArticleCategory category = new ArticleCategory
            {
                Description = articleCategoryModel.Description
            };
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    await orderDbContext.ArticleCategories.AddAsync(category);
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("新增类型 " + articleCategoryModel.Description + "成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "新增类型 " + articleCategoryModel.Description + "成功！"
                    };
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "新增类型 " + articleCategoryModel.Description + "失败！"
                    };
                }
            }
        }
        public async Task<ActionResult> UpdateArticleCategoryAsync(ArticleCategoryModel categoryModel)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    ArticleCategory updateArticleCategory = await orderDbContext.ArticleCategories.Where(a => a.Id == categoryModel.Id).FirstOrDefaultAsync();
                    if (updateArticleCategory != null)
                    {
                        updateArticleCategory.Description = categoryModel.Description;
                    }
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("修改 id:" + updateArticleCategory.Id + "成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "修改 id:" + updateArticleCategory.Id + "成功！"
                    };
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "修改 " + categoryModel.Description + "失败！"
                    };
                }
            }
        }
    }
}
