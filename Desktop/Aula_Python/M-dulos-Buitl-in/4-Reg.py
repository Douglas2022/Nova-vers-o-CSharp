import re

text = "Undermy - uma plataforma com muitos  cursos"
# 1 - Indice inicial e final de palavras
#  O r significa uma row string(string bruta)
match = re.search(r"uma plataforma",text)
print(f"Indice inicial: {match.start()}")
print(f"Indice final: {match.end()}")
print("-----------------------------------")
# 2 - Buscando o índice que possui o ponto
site = 'https://udermy.com'
match = re.search(r'\.',site)
print(match)
print("-----------------------------------")
# 3 - Buscando uma lista de caractere dentro de uma frase.
patter = "[g-m]"
result = re.findall(patter,text)
print(result)
print("-----------------------------------")
# 4 - Verificando um inicio de uma string.

rule = r'^A'
phrases = ['A casa está suja', 'O dia está lindo', 'Vamos passear']

for f in phrases:
    if re.match(rule, f):
        print(f"Corresponde a: {f}")
    else:
        print(f"Não corresponde a: {f}")

print("-----------------------------------")
# 5 - Verificando 0 final de uma string.
rule_end = r'!$'
phrases2 = "O dia está lindo!"
match = re.search(rule_end,phrases2)
if match:
    print("Sim,corresponde!")
else:
    print("Não corresponde!")
print("-----------------------------------")





