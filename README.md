# Sirius commission
 Необходимо написать программу-клиент для просмотра следующих данных: списки сотрудников, статистическая информация по спискам сотрудников в днях.

Подключение к серверу (имя сервера, база, логин, пароль) должно быть вынесено в настроечный файл или предусмотреть возможность ввода строки соединения с сервером в программе.

1. Выводить в списке сотрудников следующие данные: ФИО (в формате Фамилия И. О.), наименование статуса, наименование отдела, наименование должности, даты приема и увольнения если есть. Предусмотреть возможность сортировки списка по любому из полей. Предусмотреть фильтрацию списка по статусу, отделу, должности и части фамилии (по вхождению заданной строки в фамилию).
2. Выводить следующую статистику по списку сотрудников: количество сотрудников выбранного статуса, принятых или уволенных на работу за заданный период с разбиением по дням. Для этого предусмотреть в программе возможность выбора статуса из списка имеющихся в базе статусов, указание периода за который необходимо выводить статистику, переключение вывода статистики по принятым на работу и уволенным сотрудникам.

Обращение к таблицам выполнять через хранимые процедуры. Предусмотреть в программе все необходимые проверки корректности ввода данных.
# Известные проблемы
1) Процесс программы продолжает работу даже после завершения программы

