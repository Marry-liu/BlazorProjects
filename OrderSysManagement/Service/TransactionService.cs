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
    public class TransactionService
    {
        private readonly IDbContextFactory<OrderDbContext> Provider;
        private ILog Log;
        public TransactionService(IDbContextFactory<OrderDbContext> provider)
        {
            this.Provider = provider;
            Log = LogManager.GetLogger("TransactionService");
        }
        public List<TransationModel> transactionList { get; set; } = new List<TransationModel>();
        public void InsertTransaction(TransationModel transactionModel)
        {
            Transation transation = new Transation
            {
                TableNum = Convert.ToInt32(transactionModel.TableNum),
                TransNum = transactionModel.TransNum,
                TotalAmount = transactionModel.ArticleModels.Sum(f => f.TotalPrice),
                TransDate = DateTime.Now
            };
            List<TransArticle> transArticles = new List<TransArticle>();
            using (var orderDbContext = Provider.CreateDbContext())
            {
                int transactionId;
                if (!orderDbContext.Transations.Any())
                    transactionId = 1;
                else
                    transactionId = orderDbContext.Transations.Max(t => t.Id) + 1;
                foreach (ArticleModel f in transactionModel.ArticleModels)
                {
                    Article article = orderDbContext.Articles.First(a => a.Code == f.Code);
                    TransArticle transArticle = new TransArticle
                    {
                        TransactionId = transactionId,
                        ArticleId = article.Id,
                        Qty = f.Number,
                        TotalPrice = f.TotalPrice
                    };
                    transArticles.Add(transArticle);
                }
                try
                {
                    orderDbContext.Transations.Add(transation);
                    orderDbContext.SaveChanges();
                    orderDbContext.TransArticles.AddRange(transArticles);
                    orderDbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                }
            }
        }
        public int GetMaxTransNum()
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                if (!orderDbContext.Transations.Any())
                    return 0;
                return orderDbContext.Transations.Max(t => t.TransNum);
            }
        }
        public object[] GetTransactionDaySalesByWeekOrMouth(DateTime day, string weekOrMouth)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                DateTime endDate;
                if (weekOrMouth == "week")
                {
                    endDate = day.Date.AddDays(7);
                }
                else
                {
                    day = Convert.ToDateTime(day.Date.ToString("yyyy-MM"));
                    endDate = day.AddMonths(1);
                }
                var sales = orderDbContext.Transations.AsNoTracking().Where(t => day.Date <= t.TransDate.Date && t.TransDate.Date < endDate.Date).OrderBy(t => t.TransDate.Date).AsEnumerable().GroupBy(s => s.TransDate.Date).ToArray();
                object[] models = new object[sales.Count()];
                for (int i = 0; i < sales.Count(); i++)
                {
                    models[i] = new { type = sales[i].Key.ToShortDateString(), sales = sales[i].Sum(s => s.TotalAmount) };
                }
                return models;
            }
        }
        public object[] GetTransactionMouthSalesByYear(int year)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                var sales = orderDbContext.Transations.AsNoTracking().Where(t => year == t.TransDate.Year).AsEnumerable().GroupBy(s => s.TransDate.Date.ToString("yyyy-MM")).ToArray();
                if (sales.Count() == 0)
                    return null;
                object[] models = new object[sales.Count()];
                for (int i = 0; i < sales.Count(); i++)
                {
                    models[i] = new { type = sales[i].Key, sales = sales[i].Sum(s => s.TotalAmount) };
                }
                return models;
            }
        }

    }
}
