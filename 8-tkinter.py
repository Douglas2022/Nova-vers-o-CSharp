import tkinter as tk

# Criar a nossa janela
window = tk.Tk()
window.geometry("300x50")
window.title("Gerencia frases")


# Adicionando um frame
frame = tk.Frame(window)
frame.pack(padx=10,pady=10,fill='x',expand=True)

# Adicionando um label
label = tk.Label(frame, text="Olá mundo,Douglas")
label.pack(fill='x',expand=True)

# Adicionando um Input text
frase_label = tk.Label(frame,text="Frase")
frase_label.pack(fill = 'x',expand=True)

frase_inp = tk.Entry(frame)
frase_inp.pack(fill='x',expand=True)

# Adicionando um botão
button = tk.Button(frame,text="Enviar")
button.pack()





window.mainloop()