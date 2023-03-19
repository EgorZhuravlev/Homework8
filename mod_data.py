def modification(path, index):
    data = open(path, 'r')
    lines = data.readlines()
    data.close()
    print("1.Изменить имя")
    print("2.Изменить фамилию")
    print("3.Изменить отчество")
    print("4.Изменить номер телефона")
    print("5.Отмена")
    
    line = lines[index].split(' ') 

    userInput = int(input())
    if userInput == 1:
        line[0] = input()
    elif userInput == 2:
        line[1] = input()
    elif userInput == 3:
        line[2] = input()
    elif userInput == 4:
        line[3] = input()
    else:
        return
        
    lines[index] = ' '.join(line)
    print(lines[index])

    data = open(path, 'w')
    data.writelines(lines)
    data.close()    
    print("Изменено")
