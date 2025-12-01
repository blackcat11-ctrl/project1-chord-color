# me - this DAT
# 
# channel - the Channel object which has changed
# sampleIndex - the index of the changed sample
# val - the numeric value of the changed sample
# prev - the previous sample value
# 
# Make sure the corresponding toggle is enabled in the CHOP Execute DAT.

def onOffToOn(channel, sampleIndex, val, prev):
	return

def whileOn(channel, sampleIndex, val, prev):
	return

def onOnToOff(channel, sampleIndex, val, prev):
	return

def whileOff(channel, sampleIndex, val, prev):
	return

def onValueChange(channel, sampleIndex, val, prev):
    # 1. 获取时间和通道名称
    current_time = float(absTime.seconds)
    channel_name = channel.name
    note = op('n3')[0]

    # 2. 找到目标表格
target_table = op('chordCollection')

    # 3. 追加新行（确保使用正确的数据）
if (val > prev) :
        target_table.appendRow([current_time, channel_name, int(note)])
    # 4. 正确返回布尔值 (必需)
    return True  # 表示事件已处理