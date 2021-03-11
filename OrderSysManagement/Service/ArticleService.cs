using OrderSysManagement.Models;
using Microsoft.EntityFrameworkCore;
using OrderSysManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;

namespace OrderSysManagement.Service
{
    public class ArticleService
    {
        private readonly IDbContextFactory<OrderDbContext> Provider;
        private ILog Log;
        public ArticleService(IDbContextFactory<OrderDbContext> provider)
        {
            this.Provider = provider;
            Log = LogManager.GetLogger("ArticleService");
        }
        public async Task<List<Article>> GetArticlesAsync()
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<Article> articles = await orderDbContext.Articles.Include(c => c.ArticleCategory).AsNoTracking().OrderBy(a => a.Code).ToListAsync();
                    return articles;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public async Task DeleteArticleByCode(int code)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Article article = await orderDbContext.Articles.Where(a => a.Code == code).FirstAsync();
                    orderDbContext.Articles.Remove(article);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task MultiDeleteArticleByCodes(List<int> codes)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<Article> articles = await orderDbContext.Articles.Where(a => codes.Contains(a.Code)).ToListAsync();
                    orderDbContext.Articles.RemoveRange(articles);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task<ActionResult> InsertArticleAsync(ArticleModel articleModel)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                Article article = new Article()
                {
                    Code = articleModel.Code,
                    Description = articleModel.Name,
                    AmountMet= articleModel.AmountMet,
                    Price = articleModel.Price,
                    ArticleCategoryId = Convert.ToInt32(articleModel.ArticleCategoryId)
                };
                try
                {
                    await orderDbContext.Articles.AddAsync(article);
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("新增商品" + article.Description + "成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "新增商品" + article.Description + "成功！"
                    };
                }
                catch (Exception ex)
                {
                   // orderDbContext.Articles.Remove(article);
                    Log.Info("新增商品失败！" + ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "新增商品失败！" + ex.InnerException.Message
                    };
                }
            }
        }
        public async Task<ActionResult> UpdateArticleAsync(ArticleModel articleModel)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Article updateArticle = await orderDbContext.Articles.Where(a => a.Code == articleModel.Code).FirstOrDefaultAsync();
                    if (updateArticle != null)
                    {
                        updateArticle.Description = articleModel.Name;
                        updateArticle.AmountMet = articleModel.AmountMet;
                        updateArticle.Price = articleModel.Price;
                        updateArticle.ArticleCategoryId = Convert.ToInt32(articleModel.ArticleCategoryId);
                    }
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("修改" + articleModel.Name + "成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "修改" + articleModel.Name + "成功！"
                    };
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "修改 " + articleModel.Name + "失败！"
                    };
                }
            }
        }
        public async Task<Article> GetArticleByCodeAsync(int code)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Article article = await orderDbContext.Articles.Where(a => a.Code == code).FirstOrDefaultAsync();
                //FoodModel food = await _orderDbContext.Articles.Where(a => a.Code == code).Select(a => new FoodModel
                //{
                //    Code = a.Code,
                //    Name = a.Description,
                //    Price = a.Price,
                //    ArticleCategoryId = a.ArticleCategoryId.ToString(),
                //    ArticleCategoryName = a.ArticleCategory.Description

                    //}).AsNoTracking().FirstOrDefaultAsync();
                    return article;
                }
                catch (Exception e)
                {
                    return null;
                }
            }

        }
    }
}
