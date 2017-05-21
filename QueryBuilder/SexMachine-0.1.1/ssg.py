import sexmachine.detector as gender
import os
d = gender.Detector()

gender1 = ""
fw = open('string1.txt','w')
fr = open('string.txt')
for line in fr:
	gender1 = d.get_gender(line.strip())
	fw.write(gender1+"\n") # python will convert \n to os.linesep
fr.close()
fw.close() # you can omit in most cases as the destructor will call it

