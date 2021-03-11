using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderSysManagement.Data;
using OrderSysManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionResult = OrderSysManagement.Models.ActionResult;

namespace OrderSysManagement.Service
{
    public class CostService
    {
        private readonly IDbContextFactory<OrderDbContext> Provider;
        private ILog Log;
        public CostService(IDbContextFactory<OrderDbContext> provider)
        {
            this.Provider = provider;
            Log = LogManager.GetLogger("ArticleService");
        }
        public async Task<List<Cost>> GetCostsAsync()
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<Cost> costs = await orderDbContext.Costs.AsNoTracking().OrderBy(c => c.Id).ToListAsync();
                    return costs;
                }
                catch
                {
                    return new List<Cost>();
                }
            }
        }
        public async Task DeleteCostById(int id)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Cost cost = await orderDbContext.Costs.Where(a => a.Id == id).AsNoTracking().FirstAsync();
                    orderDbContext.Costs.Remove(cost);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task MultiDeleteCostByIds(List<int> ids)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    List<Cost> costs = await orderDbContext.Costs.Where(a => ids.Contains(a.Id)).AsNoTracking().ToListAsync();
                    orderDbContext.Costs.RemoveRange(costs);
                    await orderDbContext.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }
        public async Task<Cost> GetCostByIdAsync(int id)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Cost cost = await orderDbContext.Costs.Where(a => a.Id == id).AsNoTracking().FirstOrDefaultAsync();
                    return cost;
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
        public async Task<ActionResult> InsertCostAsync(CostModel model)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                Cost cost = new Cost()
                {
                    Cost_Date = model.Cost_Date,
                    Cost_Description = model.Cost_Description,
                    Cost_Price = model.Cost_Price
                };
                try
                {
                    await orderDbContext.Costs.AddAsync(cost);
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("成本" + model.Cost_Description + "记录成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "成本" + model.Cost_Description + "记录成功！"
                    };
                }
                catch (Exception ex)
                {
                    // orderDbContext.Articles.Remove(article);
                    Log.Info("成本记录失败！" + ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "成本记录失败！" + ex.InnerException.Message
                    };
                }
            }
        }
        public async Task<ActionResult> UpdateCostAsync(CostModel model)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                try
                {
                    Cost update = await orderDbContext.Costs.Where(a => a.Id == model.Id).FirstOrDefaultAsync();
                    if (update != null)
                    {
                        update.Cost_Date = model.Cost_Date;
                        update.Cost_Description = model.Cost_Description;
                        update.Cost_Price = model.Cost_Price;
                    }
                    await orderDbContext.SaveChangesAsync();
                    Log.Info("修改Cost id:" + model.Id + "成功！");
                    return new ActionResult()
                    {
                        Status = ActionStatus.OK,
                        Msg = "修改Cost id:" + model.Id + "成功！"
                    };
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                    return new ActionResult()
                    {
                        Status = ActionStatus.Failed,
                        Msg = "修改Cost id:" + model.Id + "失败！"
                    };
                }
            }
        }
        public object[] GetCostDaySalesByMouth(DateTime day)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                DateTime endDate;
                day = Convert.ToDateTime(day.Date.ToString("yyyy-MM"));
                endDate = day.AddMonths(1);
                var sales = orderDbContext.Costs.AsNoTracking().Where(t => day.Date <= t.Cost_Date.Date && t.Cost_Date.Date < endDate.Date).OrderBy(t => t.Cost_Date.Date).AsEnumerable().GroupBy(s => s.Cost_Date.Date).ToArray();
                object[] models = new object[sales.Count()];
                for (int i = 0; i < sales.Count(); i++)
                {
                    models[i] = new { type = sales[i].Key.ToShortDateString(), sales = sales[i].Sum(s => s.Cost_Price) };
                }
                return models;
            }
        }
        public object[] GetCostMouthSalesByYear(int year)
        {
            using (var orderDbContext = Provider.CreateDbContext())
            {
                var sales = orderDbContext.Costs.AsNoTracking().Where(t => year == t.Cost_Date.Year).AsEnumerable().GroupBy(s => s.Cost_Date.Date.ToString("yyyy-MM")).ToArray();
                if (sales.Count() == 0)
                    return null;
                object[] models = new object[sales.Count()];
                for (int i = 0; i < sales.Count(); i++)
                {
                    models[i] = new { type = sales[i].Key, sales = sales[i].Sum(s => s.Cost_Price) };
                }
                return models;
            }
        }
    }
}
