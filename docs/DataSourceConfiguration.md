# Настройка источников данных для NiFi и работа с ними

## Источники данных

1. Открываем сайт Nifi https://localhost:8443/nifi/
</br>логин: flexberryuser
</br>пароль: jhvjhvjhvjhv

2. Открываем конфигурацию группы потоков
</br>![Nifi Configuration](images/nifi_flow_configuration.png)

3. Добавляем источник данных
</br>Вкладка **Controller Services**, конопка **Create** справа над списком
</br>![Nifi Add DataSource](images/nifi_ds_add.png)

4. Выбираем тип источника данных
</br>Нас интересует тип **DBCPConnectionPool 1.20.0**
</br>![Nifi DataSource Type](images/nifi_ds_type.png)

5. Редактируем источник данных
</br>В списке появится наш источник данных, для редактирования нажимаем кноку **configure** (мальенькая шестеренка)
</br>![Nifi DataSource Configure](images/nifi_ds_type_configure.png)

6. Задаем параметры для нашего соединения
</br>Вкладка **Settings**, атрибут **Name** = DBCPConnectionPoolPostgreSQL
</br>![Nifi DataSource Name](images/nifi_ds_type_configure_name.png)
</br>Вкладка **Properties**
</br>Атрибут **Database Connection URL** = jdbc:postgresql://app-postgre-db:5432/appdb (имя_сервера:порт/имя_бд)
</br>Атрибут **Database Driver Class Name** = org.postgresql.Driver
</br>Атрибут **Database Driver Location(s)** = /opt/jdbc/postgresql-42.5.4.jar (этот пакет т.к. он используется в [докере](https://github.com/Flexberry/Flexberry.NiFiSample/blob/ac70635e8c4cc7626efa6fe3f48e6e90bb646020/src/Docker/Dockerfile.NiFi#L9))
</br>Атрибут **Database User** = flexberryuser
</br>Атрибут **Database Password** = jhv ([Параметры БД](https://github.com/Flexberry/Flexberry.NiFiSample/blob/ac70635e8c4cc7626efa6fe3f48e6e90bb646020/src/Docker/SQL/Dockerfile.PostgreSql#L4))
</br>![Nifi DataSource Properies](images/nifi_ds_type_configure_props.png)
</br>Применяем изменения, кнопка **Apply**

7. Включаем источник данных
</br>Кнопка в виде молнии **Enable**
</br>![Nifi DataSource Properies](images/nifi_ds_type_enable.png)

После этого источником данных можно пользоваться.

Чтобы снова отредактировать источник данных, нужно его сначала выключить, кнопка **Disable**, а затем нажать на кнопку **Configure**.

8. Задаем параметры для ClickHouse
</br>Вкладка **Settings**, атрибут **Name** = DBCPConnectionPoolClickHouse
</br>Вкладка **Properties**
</br>Атрибут **Database Connection URL** = jdbc:clickhouse://clickhouse-db:8123/default (имя_сервера:порт/имя_бд)
</br>Атрибут **Database Driver Class Name** = com.clickhouse.jdbc.ClickHouseDriver
</br>Атрибут **Database Driver Location(s)** = /opt/jdbc/clickhouse-jdbc-0.4.1-shaded.jar (этот пакет т.к. он используется в [докере](https://github.com/Flexberry/Flexberry.NiFiSample/blob/ac70635e8c4cc7626efa6fe3f48e6e90bb646020/src/Docker/Dockerfile.NiFi#L9))
</br>Атрибут **Database User** = default
</br>Атрибут **Database Password** = P@ssw0rd ([Параметры БД](https://github.com/Flexberry/Flexberry.NiFiSample/blob/ac70635e8c4cc7626efa6fe3f48e6e90bb646020/src/Docker/SQL/Dockerfile.ClickHouse#L8))
</br>![Nifi DataSource Properies](images/nifi_ds_type_clickhouse.png)
</br>Применяем изменения, кнопка **Apply**

## Пример использования

Для примера вызовем формирование списка всех имен таблиц в базе данных

1. Создаем процессор
</br>В главном окне на панели инструментов нажимаем на **Processor** и перетаскиваем его в рабочую область
</br>![Nifi Processor Add](images/nifi_procc_add.png)
</br>Выбираем тип **ListDatabaseTables 1.20.0**

2. Редактируем процессор
</br>Вкладка **Settings**, атрибут **Name** = ListDatabaseTablesPostgreSQL
</br>Вкладка **Properties**, атрибут **Database Connection Pooling Service** = DBCPConnectionPoolPostgreSQL (выбрать из списка)
</br>![Nifi Processor Edit](images/nifi_procc_edit.png)
</br>Применяем изменения, кнопка **Apply**

3. Аналогично с п.2 добавляем процессор для ClickHouse
</br>Вкладка **Settings**, атрибут **Name** = ListDatabaseTablesClickHouse
</br>Вкладка **Properties**, атрибут **Database Connection Pooling Service** = DBCPConnectionPoolClickHouse (выбрать из списка)

4. Добавляем объект Funnel
</br>В главном окне на панели инструментов нажимаем на **Funnel** и перетаскиваем его в рабочую область
</br>![Nifi Funnel](images/nifi_funnel.png)
</br>Соединяем наши процессоры с Funnel. Наводим указателем на центр процессора в рабочей области, появится стрелка, 
</br>![Nifi Processor Arrow](images/nifi_proc_arrow.png)
</br>перетаскиваем ее на объект Funnel, пока линия соединения не станет зеленого цвета.

5. Примерная схема, которая должна получится
</br>![Nifi Scheme](images/nifi_scheme.png)

Можно дергать каждый процесс отдельно. Для этого нажимаем правой кнопкой мыши на процессор и выбираем пункт **Run once**.

## Сбор данных из Excel

Положим файл в докер-контейнер. Для тестирования можно скопировать .xlsx файл с локальной машины в докер-контейнер nifi. Для этого:

1. Создаем файл, например `cars.xlsx` на локальной машине.
2. Присоединяемся терминалом (например, с помощью плагина Doker в VS Code) к контейнеру `nifisample/nifi`. Создадим директорию для файлов командой `mkdir excelsheets`
3. В другом, не подсоединенном к докеру терминале выполняем команду `docker cp <полный_путь_до_файла>\cars.xlsx <id_контейнера>:/opt/nifi/nifi-current/excelsheets/cars.xlsx`.

Вычитаем данные из Excel файла в NiFi:

1. Из меню сверху перетягиваем на рабочую зону Processor, из списка выбираем `GetFile`
2. На вкладке Properties:
   1. Input Directory - путь до файла в контейнере, в нашем случае `/opt/nifi/nifi-current/excelsheets`
   2. File Filter - фильтр на имя файла. Можно задавать маски, но в нашем тестовом случае прописываем имя конкретного файла - `cars.xlsx`

![GetFile Processor](images/getfile.png)

3. Добавляем еще один Processor - `ConvertExcelToCSVProcessor`. На вкладке Properties в поле `Sheets to Extract` прописываем имена листов из excel файла, которые хотим передать.
4. Соединяем стрелочкой объекты GetFile и ConvertExcelToCSVProcessor.
5. Добавляем в рабочую зону объект Funnel. Соединяем ConvertExcelToCSVProcessor с Funnel тремя стрелками - отдельно для failure, success, original.

![Schema](images/schema.png)

Готово, можно запускать процессы передачи.
