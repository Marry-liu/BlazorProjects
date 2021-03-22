using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HappyBallAnalysisProject.Service
{
    public class PrintJobService
    {
        public string PrinterName { get; set; }
        //定义一个字符串流，用来接收所要打印的数据
        private StringReader sr;
        //str要打印的数据
        private readonly IDbContextFactory<DBContext> Provider;
        //private ILog Log;
        public PrintJobService(IDbContextFactory<DBContext> provider)
        {
            this.Provider = provider;
            using (var orderDbContext = Provider.CreateDbContext())
            {
                PrinterName = orderDbContext.PrintParameter.FirstOrDefault().PrinterName;
            }
            //Log = LogManager.GetLogger("PrintJobService");
        }
        //public async Task<ActionResult> UpdatePrintParameterAsync(PrintParameterModel model)
        //{
        //    using (var orderDbContext = Provider.CreateDbContext())
        //    {
        //        try
        //        {
        //            PrintParameter update = await orderDbContext.PrintParameter.FirstOrDefaultAsync();
        //            if (update != null)
        //            {
        //                update.PrinterName = model.PrinterName;
        //            }
        //            else
        //            {
        //                await orderDbContext.PrintParameter.AddAsync(new PrintParameter
        //                {
        //                    PrinterName = model.PrinterName
        //                });
        //            }
        //            await orderDbContext.SaveChangesAsync();
        //            Log.Info("修改成功！");
        //            return new ActionResult()
        //            {
        //                Status = ActionStatus.OK,
        //                Msg = "修改成功！"
        //            };
        //        }
        //        catch (Exception ex)
        //        {
        //            Log.Error(ex.ToString());
        //            return new ActionResult()
        //            {
        //                Status = ActionStatus.Failed,
        //                Msg = "修改 " + model.PrinterName + "失败！"
        //            };
        //        }
        //    }
        //}
        public bool Print(string str)
        {
            bool result = true;
            try
            {
                sr = new StringReader(str);
                PrintDocument pd = new PrintDocument();
                pd.PrintController = new System.Drawing.Printing.StandardPrintController();
                pd.DefaultPageSettings.Margins.Top = 1;
                pd.DefaultPageSettings.Margins.Left = 0;
                //pd.DefaultPageSettings.PaperSize.Width = 320;
                //pd.DefaultPageSettings.PaperSize.Height = 5150;
                //pd.PrinterSettings.PrinterName = pd.DefaultPageSettings.PrinterSettings.PrinterName;//默认打印机
                pd.PrinterSettings.PrinterName = PrinterName;
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                result = false;
                throw;
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
            return result;
        }
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            Font printFont = new Font("Arial", 10);//打印字体

            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            String line = "";

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            while (count < linesPerPage && ((line = sr.ReadLine()) != null))
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }
}
