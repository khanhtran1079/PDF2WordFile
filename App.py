from tkinter import *
import tkinter as tk

class Application:
    def __init__(self):
        self.Screen = Tk(state = tk.NORMAL)
        HeadFrame = Frame(self.Screen, height= 300 , width= 1360 )
        canvas = Canvas(self.Screen, height=300, width=1360, bg="#3399ff")
        canvas.pack()
        
        rectangleMenu = canvas.Rectangle(0,0,300,1360,fill='#3399ff')
        HeadFrame.pack()


    def show(screen):
        if 'normal' != screen.state():
            screen.mainloop()


AppWindow = Application()
AppWindow.show()