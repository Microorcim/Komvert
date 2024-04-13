# ConvertSolidCompass
- [x]  Сначала Ui

- [ ] Проставка тестовых данных 
  - [ ] Проверка работы на примере с экселем

- [ ] Создание конвертера обьектов
  - [ ] Проверка на листах эксель

- [ ] соединение


В Солидворкс детали храняться так
CREATE TABLE [tew].[tew_catreference](
	[cre_reference]                 //Образец
	[cre_uid]                       
	[cre_elementcount]              //Количество цепей
	[cre_terminalcount]             //Количество точек подкл
	[cre_manufacturer]              //Производитель
	[cre_value1]                    //Данные производителя 1
	[cre_value2]                    //Данные производителя 2
	[cre_value3]                    //Данные производителя 3
	[cre_value4]                    //Данные производителя 4
	[cre_value5]                    //Данные производителя 5
	[cre_value6]                    //Данные производителя 6
	[cre_usevoltage]                //Использовать напряжение
	[cre_covoltage]                 //Управление напряжение
	[cre_usefrequency]              //Использовать частота
	[cre_cofrequency]               //Управление частота
	[cre_objecttype]                //Тип Основное Плк Стойка и тр
	[cre_implantx]                  //Ширина
	[cre_implanty]                  //Высота
	[cre_implantz]                  //Глубина
	[cre_modificationdate]          //Дата изменения
	[cre_creationdate]              //Дата создания
	[cre_nod_clauid]                //Номер класса 
	[cre_cla_name]                  
	[cre_lib_name]                  //Название библиотеки в которую входит
	[cre_bloschname]                //Название блоксхемы / Принципиальная схема
	[cre_update]                    
	[cre_partname]                  //Название 3D детали / 3D-деталь
	[cre_isobsolete]                
	[cre_datatype]                  
	[cre_blosynname]                //Название Структурная схема
	[cre_partnametwod]              //Название Двухмерные посадочные места
	[cre_articlename]               //Номер Артикуль 
	[cre_value7]                    
	[cre_wiringpartname]            //связанное обозначение Метка соединения
	[cre_rootmark]  				//Корень метки
	[cre_folderpartname]    		
	[cre_ecpcontactid]  			-1
	[cre_suppliername]  			//Имя поставщика
	[cre_stocknumber]   			//Ссылочный номер / идентификатор детали для поставщика
	[cre_serie] 					//Серия
	[cre_pcbfilename]   			//Файл печатной платы
	[cre_pcbfolderpath] 			
	[cre_datasheet] 				//Спецификация
	[cre_terminalstripsymbol]   	//клеммные колодки символ
	[cre_externalid]    			//Внешний идентификатор
	[cre_modifiedby]    			//Пользователь который изменил
	[cre_excludefrombom]    		
	[cre_tst_code]  				
	[cre_createdby] 				//Пользователь который создал
 CONSTRAINT [idxtew_catreference_1] PRIMARY KEY NONCLUSTERED
