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


window.mainloop()