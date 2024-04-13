using ConvertSolidCompass.Models.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSolidCompass.Models_Solid
{
    internal class SolidDataStore
    {
        /// <summary>
        /// Список каталогов
        /// </summary>
        /// <returns>С пустыми полями</returns>
        public static List<string> GetClasses()
        {
            //база Classification
            using (TewClassificationContext context = new TewClassificationContext())
            {
                //выбрать все NodUdfilename из таблицы TewNodes
                var f = context.TewNodes.Select(x => x.NodUdfilename).ToList();
                return f;
            }
        }
        /// <summary>
        /// Список наименований деталей (Образец)
        /// </summary>
        /// <returns></returns>
        public static List<string> GetNames()
        {
            using (TewCatalogContext context = new TewCatalogContext())
            {
                //выбрать все CreReference из таблицы TewCatreferences
                var f = context.TewCatreferences.Select(x => x.CreReference).ToList();
                return f;
            }
        }
        /// <summary>
        /// Список производителей 
        /// </summary>
        /// <returns></returns>
        public static List<string> GetManufactureres()
        {
            using (TewCatalogContext context = new TewCatalogContext())
            {
                //выбрать все CreReference из таблицы TewCatreferences
                var f = context.TewCatreferences.Select(x => x.CreManufacturer).Distinct().ToList();
                return f;
            }
        }

    }

}
