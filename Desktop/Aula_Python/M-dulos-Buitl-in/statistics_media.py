import statistics
# Aplicando a média 
print(f"A média é: {statistics.mean([3,2,3,8,9])}")
print('-------------------------------------------------')
# Aplicando a médiana
print(f"A mediana é: {statistics.median([1, 2, 4, 8, 9])}")
print(f"A mediana é: {statistics.median([1,2,3,7,8,9])}")
print('-------------------------------------------------')
# A moda
print(f"A moda é: {statistics.mode([1,2,3,7,8,9,5,9,8,5,8,7,9])}")
print('-------------------------------------------------')
# Desvio padrão
"""
- Quanto mais próximo de 0 for o dsvio padrão,significa que os dados 
do conjunto estão dispersos.
"""
print(statistics.stdev([1,1.5,2,2.5,3,3.5,4,4.5]))