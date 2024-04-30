# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
def ave(array_num):
    result = 0
    con = 0
    for item in array_num:
        value, is_num = try_parse(item)
        if is_num:
            result += value
            con += 1

    if con == 0:
        return 0
    else:
        return result / con

def try_parse(value):
    try:
        return int(value), True
    except ValueError:
        return 0, False

num = input("請輸入數字(多個數字用空白分隔):")
array_num = num.split()
print("該列表的平均數:" + str(ave(array_num)))