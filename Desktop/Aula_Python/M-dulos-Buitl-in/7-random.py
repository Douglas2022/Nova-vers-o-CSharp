import random
# # 1-Selecione um valor aleatório de uma lista
# list1 = [7,6,4,3,2,1]
# print(random.choice(list1))
# # 1-Gera um número em intervalo de valores
# r1 = random.randint(5,15)
# print(r1)
# 1-Seleciona um caractere aleatório de uma syting
# name = 'Eliane'
# r2 = random.choice(name)
# print(r2)
# 1-Seleciona mais de um valor aleatório - Random.sample(sequencia(tamanho)) 
list1 = [7,6,4,3,2,1]
list2 = [8,9,7,6,4,3,2,1,0]
print(random.sample(list1,4))
print(random.sample(list2,3))
print('----------------------------------')
s = "Douglas e Mãe"
print(random.sample(s,2))
print('----------------------------------')
# Progrma de sorteio
done = False
while not done:
    print("O que você deseja fazer?")
    print("1- Advinhar o número")
    print("2- Sair")

    choice = input(">")
    if choice == "1":
        print("=================Advinhe o número de 1 a 10==================\n")
        number = int(input("Digite o número de 1 a 10:\n"))
        result = random.randint(1,10)
        if number == result:
            print("Parabéns para você!")
        else:
            print(f"Tente novamente.O número sorteado foi:{result}")
    elif choice == "2":
        done = True
    else:
        print("Opção invalida. Escolha a opção 1 e 2")
        












