using My.DataAccess.Framework;
using My.Entity.Demo;
using My.Entity.Demo.Pro;
using My.Entity.Demo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (MyDbContext db = new MyDbContext())
            {
                //获取表数据
                //List<DemoStudent> list = db.DemoStudent.AsNoTracking().ToList();
                //获取视图数据
                //List<ViewDemostudent> list2 = db.ViewDemostudent.AsNoTracking().ToList();
                ////添加数据
                //DemoStudent demo = new DemoStudent();
                //demo.Stuname = "77777";
                //db.Entry(demo).State = System.Data.Entity.EntityState.Added;
                //db.SaveChanges();

                //修改数据
                //DemoStudent model = db.DemoStudent.AsNoTracking().FirstOrDefault(x => x.Stuname == "77777");
                //model.Stuname = "haha";
                //db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                //删除数据
                //DemoStudent model = db.DemoStudent.AsNoTracking().FirstOrDefault(x => x.Stuname == "haha");
                //db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                //db.SaveChanges();

                //使用存储过程
                //UspDemoGetdemostudent proc = new UspDemoGetdemostudent()
                //{
                //    @StuName = "123"
                //};
                //Dictionary<string, object> outObjs = new Dictionary<string, object>(); // 接收输出参数
                //dynamic outPutDtos = proc.QueryList<dynamic>(outObjs); // 调用返回一个集合
                //int rowCount = Convert.ToInt32(outObjs["@OutCount"]); // 输出参数以Out开头

            }
        }
    }
}
