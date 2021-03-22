using HappyBallAnalysisProject.Data;
using HappyBallAnalysisProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Service
{
    public class WiningRecordService
    {
        private readonly IDbContextFactory<DBContext> Provider;
        //private ILog Log;
        public WiningRecordService(IDbContextFactory<DBContext> provider)
        {
            this.Provider = provider;
            //Log = LogManager.GetLogger("ArticleCategoryService");
        }
        public async Task<bool> InputRecord(WiningRecordModel model)
        {
            using (var ctx= Provider.CreateDbContext())
            {
                WiningRecord data = new WiningRecord
                {
                    Period=model.Period,
                    Date=model.Date,
                    RedNumber1=model.RedNumber1,
                    RedNumber2=model.RedNumber2,
                    RedNumber3=model.RedNumber3,
                    RedNumber4=model.RedNumber4,
                    RedNumber5=model.RedNumber5,
                    RedNumber6=model.RedNumber6,
                    BlueNumber=model.BlueNumber,
                    TypeId=model.TypeId
                };
                try
                {
                    await ctx.WiningRecords.AddAsync(data);
                    await ctx.SaveChangesAsync();
                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
               
            }
        }
        //public async Task<bool> InputStatistics(ButtonTypeModel[] redButtonTypes, ButtonTypeModel blueButtonTypes)
        //{
        //    using (var ctx = Provider.CreateDbContext())
        //    {
        //        for (int i = 0; i < redButtonTypes.Length; i++)
        //        {
        //            var red = await ctx.NumbersStatistics.Where(r => r.TypeId ==(int) BallType.DoubleRed && r.Number == redButtonTypes[i].Num).FirstAsync();
        //            red.Times += 1;
        //        }
        //        var blue= await ctx.NumbersStatistics.Where(r => r.TypeId == (int)BallType.DoubleBlue && r.Number == blueButtonTypes.Num).FirstAsync();
        //        blue.Times += 1;
        //        try
        //        {
        //            await ctx.SaveChangesAsync();
        //            return true;
        //        }
        //        catch (Exception e)
        //        {
        //            return false;
        //        }
        //    }
        //}
        public async Task<object[]> DoubleSelectRedStatistics()
        {
            using (var ctx = Provider.CreateDbContext())
            { 
                try
                {
                    var red = await ctx.NumbersStatistics.AsNoTracking().Where(r => r.TypeId == (int)BallType.DoubleRed).OrderByDescending(r => r.Times).ToListAsync();
                    object[] model = new object[red.Count()];
                    for (int i = 0; i < red.Count(); i++)
                    {
                        model[i] = new { type = red[i].Number, sales = red[i].Times };
                    }
                    return model;
                }
                catch (Exception e)
                {
                    return new object[33];
                }
            }
        }
        public async Task<object[]> DoubleSelectBlueStatistics()
        {
            using (var ctx = Provider.CreateDbContext())
            {
                try
                {
                    var blue = await ctx.NumbersStatistics.AsNoTracking().Where(r => r.TypeId == (int)BallType.DoubleBlue).OrderByDescending(r => r.Times).ToListAsync();
                    object[] model = new object[blue.Count()];
                    for (int i = 0; i < blue.Count(); i++)
                    {
                        model[i] = new { type = blue[i].Number, sales = blue[i].Times };
                    }
                    return model;
                }
                catch (Exception e)
                {
                    return new object[16];
                }
            }
        }
        public async Task<object[]> BigSelectRedStatistics()
        {
            using (var ctx = Provider.CreateDbContext())
            {
                try
                {
                    var red = await ctx.NumbersStatistics.AsNoTracking().Where(r => r.TypeId == (int)BallType.BigRed).OrderByDescending(r => r.Times).ToListAsync();
                    object[] model = new object[red.Count()];
                    for (int i = 0; i < red.Count(); i++)
                    {
                        model[i] = new { type = red[i].Number, sales = red[i].Times };
                    }
                    return model;
                }
                catch (Exception e)
                {
                    return new object[35];
                }
            }
        }
        public async Task<object[]> BigSelectBlueStatistics()
        {
            using (var ctx = Provider.CreateDbContext())
            {
                try
                {
                    var red = await ctx.NumbersStatistics.AsNoTracking().Where(r => r.TypeId == (int)BallType.BigBlue).OrderByDescending(r => r.Times).ToListAsync();
                    object[] model = new object[red.Count()];
                    for (int i = 0; i < red.Count(); i++)
                    {
                        model[i] = new { type = red[i].Number, sales = red[i].Times };
                    }
                    return model;
                }
                catch (Exception e)
                {
                    return new object[12];
                }
            }
        }
    }
}
