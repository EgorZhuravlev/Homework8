def delete(path, index):
    data = open(path, 'r')
    lines = data.readlines()
    data.close()
    lines.pop(index)
    data = open(path, 'w')
    data.writelines(lines)
    data.close()    
    print("Удалено")
