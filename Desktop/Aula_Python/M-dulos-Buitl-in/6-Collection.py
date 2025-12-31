from collections import Counter,namedtuple,deque
from operator import itemgetter

# 1- Lista de frutas e quero realizar a contagem
fruits = ["Banana","Maçã","Perâ","Uva","Salada-mista","Graviola","Banana",
          "Perâ","Uva","Salada-mista","Graviola","Banana","Banana","Maçã","Perâ","Uva",
          "Salada-mista","Graviola","Banana",
          ]
print(fruits)
print(Counter(fruits))
print("----------------------------------------------------------------------")
# 2- Ultilizando a tupla nomeada
game = namedtuple('game',['name','price','note'])
g1 = game("Fifa23",90.5,8.5)
g2 = game("Residente evil 4 - Remake",300,10.0)
print(g1,g2)
print("----------------------------------------------------------------------")
# 3- Ordenar um dicionário
students = {"Pedro":23,"Ana":22,"Ronaldo":26,"Janaina":25}
# a = sorted(students.items(),key = itemgetter(1))
a = sorted(students.items(),key = itemgetter(0))
print(a)
# 3- Ultilizando uma fila em ambas as extremidades
deq = deque([20,40,60,80])
deq.appendleft(10)
print(deq)
deq.append(90)
deq.popleft()
deq.pop()
print(deq)

