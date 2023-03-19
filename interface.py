from show_data import *
from find_data import *


def menuHello(path):
    print("1.Добавить")
    print("2.Вывести всех")
    print("3.Поиск по фамилии")
    print("4.Выход")
    userInput = int(input())
    if userInput == 1:
        addData(path)
        return True
    if userInput == 2:
        printAll(path)
        return True
    if userInput == 3:
        find(path, input("Введите фамилию: "))
        return True
    if userInput == 4:
        return False

def addData(path):
    data = open(path, 'a') 
    first_name = input("Введите имя: ")
    second_name = input("Введите фамилию: ")
    mid_name = input("Введите отчество: ")
    number = input("Введите номер телефона: ")
    item = [first_name, second_name, mid_name, number]
    s = ' '
    data.writelines(s.join(item) + ' \n')
    data.close()

