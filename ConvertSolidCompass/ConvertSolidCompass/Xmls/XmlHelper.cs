using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConvertSolidCompass.Xmls
{
    internal class XmlHelper
    {
        /// <summary>
        /// Получить Header с определенной локализацией из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="lang">Локализация (ru)</param>
        /// <returns>Header.Text</returns>
        static string GetHeader(string path, string lang)
        {
            //Создаем сериализатор
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SECTIONS));
            //Открываем файл
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                //Десиариализуем файл в обьект SECTIONS
                var x = (SECTIONS)xmlSerializer.Deserialize(fs);
                //Берем первый LANGUAGE в EWHEADER.DESCRIPTION, подходящий под l.Lang == lang
                var name = x.EWHEADER.DESCRIPTION.LANGUAGE.FirstOrDefault(l => l.Lang == lang);

                return name.Text;
            }
        }
    }
}
