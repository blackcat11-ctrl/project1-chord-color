# 在Script DAT中（如`findColor`）
target_sum = op('null4')[0]  # 输入数据来源
table = op('table3')
match_found = False


for row in range(0, table.numRows - 1):  # 跳过标题行
    if float(table[row, 3]) == target_sum:
        
        op('select1').par.rowindexstart = row;
op('select1').par.rowindexend = row;
match_found = True
        break

if not match_found:
    print("未找到匹配的sum值")

