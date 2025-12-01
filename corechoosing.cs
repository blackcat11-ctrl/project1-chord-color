# Get your DAT table
chordTable = op('chordCollection')
calTable = op('calTable')

# Make a list of (note_time, note_name) tuples, skipping the header
note_time = float(chordTable[0, 0])
note_name = int(chordTable[0, 2])
sum = 0
my_array = []

while (note_name > 32) :
    note_name -= 12
for row in range(0, calTable.numRows):
    if (abs(note_name - int(calTable[row, 0])) < 0.1):
        sum += calTable[row, 1]
        my_array.append(note_name)

for lineIndex in range(1, chordTable.numRows):
    if (lineIndex <= chordTable.numRows - 1) and(float(chordTable[lineIndex, 0]) - note_time < 0.7) :
        note_time = float(chordTable[lineIndex, 0])
        note_name = int(chordTable[lineIndex, 2])
        while (note_name > 32) :
            note_name -= 12
        if note_name in my_array:
break
        for row in range(0, calTable.numRows):
            if (abs(note_name - int(calTable[row, 0])) < 0.1):
                sum += calTable[row, 1]
        lineIndex += 1
    else : 
        break



op('sumget')[0, 0] = sum
op('chordCollection').deleteRow(0)
value = 0
op('bool')[0, 0] = 0


