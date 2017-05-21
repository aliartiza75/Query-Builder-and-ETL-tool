#!/usr/bin/python
# -*- coding: iso-8859-15 -*-
from moviepy.editor import *
import glob
import sys

f = open('file_names.txt')
i = 0
for line in f:
    if i == 0:
    	inputFolder = line.strip()
    if i == 1:
    	fileFormat = line.strip()
    if i == 2:
    	waterMarkingText = line.strip()    	
    if i == 3:
    	outputFolder = line.strip()    
    i = i +1   	

f.close()


f =  glob.glob('C:\Users\john\Downloads\*.avi')
f =  glob.glob(inputFolder+"\*"+fileFormat)
i = 1
for line in f:
	line.strip()
	
	my_clip = VideoFileClip(line, audio=True)  #  The video file with audio enabled

	w,h = my_clip.size  # size of the clip

	# A CLIP WITH A TEXT AND A BLACK SEMI-OPAQUE BACKGROUND

	txt = TextClip(waterMarkingText, font='Amiri-regular',
	                   color='white',fontsize=24)

	txt_col = txt.on_color(size=(my_clip.w + txt.w,txt.h-10),
	                  color=(0,0,0), pos=(6,'center'), col_opacity=0.6)

	# This example demonstrates a moving text effect where the position is a function of time(t, in seconds).
	# You can fix the position of the text manually, of course. Remember, you can use strings,
	# like 'top', 'left' to specify the position
	#txt_mov = txt_col.set_pos("right", "bottom").set_duration(20)


	txt_mov = txt_col.set_pos( lambda t: (max(w/30,int(w-0.5*w*t)),
	                                  max(5*h/6,int(1*t))) )
	#(max(w/30,int(w-0.5*w*t))
	# Write the file to disk

	#txt_clip = TextClip("Sc_asasdasdasdasdasd", fontsize=12, color='black').set_pos("right", "bottom").set_duration(10)


	final = CompositeVideoClip([my_clip,txt_mov])
	final.duration = my_clip.duration
	final.write_videofile("C:\Users\john\Desktop\WATERMARKED"+str(i)+".mp4",fps=24,codec='libx264')
	final.write_videofile(outputFolder+"\WATERMARKED"+str(i)+".mp4",fps=24,codec='libx264')
	i = i + 1
	
	
