# Создать телефонный справочник с возможностью импорта и экспорта данных в формате .txt. Фамилия, имя, 
# отчество, номер телефона - данные, которые должны находиться в файле.

# 1. Программа должна выводить данные
# 2. Программа должна сохранять данные в текстовом файле
# 3. Пользователь может ввести одну из характеристик для поиска определенной записи(фамилии человека)
# 4. Использование функций. Ваша программа не должна быть линейной

# 1) Добавить 
# 2) Вывести всех
# 3) Поиск по фамилии

# Домашнее задание:
# Дополнить телефонный справочник возможностью изменения и удаления данных. 
# Пользователь также может ввести имя или фамилию, и Вы должны реализовать функционал для изменения и удаления данных

from interface import *
file_path = 'HomeWork_8/file.txt'
flag = True
while(flag):
    flag = menuHello(file_path)

    