using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Unity;
using Microsoft.Practices.Unity.Configuration;
using BussinessInterface;
using BussinessServer;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 依赖了细节
            //using (OEMREntities dbcontext=new OEMREntities())
            //{
            //    OEMRSysDictionry sysDictionry = new OEMRSysDictionry();
            //    sysDictionry.DicCode = "BasicEleType";
            //    sysDictionry.DicName = "类型";
            //    sysDictionry.DicValue = "1";
            //    sysDictionry.DicShowValue = "文本";
            //    sysDictionry.DicIsValidity = "1";
            //    dbcontext.OEMRSysDictionry.Add(sysDictionry);
            //   OEMRTest test = new OEMRTest();
            //    test.Name = "111";
            //    //dbcontext.OEMRTest.Attach(test);
            //    dbcontext.OEMRTest.Add(test);
            //    dbcontext.SaveChanges();
            //}
            #endregion


            #region IOC+EF
            UnityConfigurationSection unity = (UnityConfigurationSection)ConfigurationManager.GetSection(UnityConfigurationSection.SectionName);
            UnityContainer unityContainer = new UnityContainer();
            unity.Configure(unityContainer, "MyContainer");

            IBaseService sever = unityContainer.Resolve<IBaseService>();
            //using (IBaseService sever= unityContainer.Resolve<IBaseService>())
            //{
            //    OEMRTest test = new OEMRTest();
            //    test.Name = "111";
            //    sever.Insert<OEMRTest>(test);
            //}




            #endregion

            Console.Read();

        }
    }
}
