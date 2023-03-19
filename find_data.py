from mod_data import *
from delete_data import *

def find(path, text):
    data = open(path, 'r')
    lines = data.readlines()
    for index in range(len(lines)):
        if lines[index].split(' ')[1] == text:
            print(lines[index])
            print('\n')
            data.close()
            findMenu(path, index)
            return
    print("Не найден!")
    data.close()

def findMenu(path, index):
    print("1.Удалить запись")
    print("2.Изменить запись")
    print("3.Вернуться в главное меню")
    userInput = int(input())
    if userInput == 1:
        delete(path, index)
        return True
    if userInput == 2:
        modification(path, index)
        return True
    if userInput == 3:
        return False