number = int(input())

print("ta liczba rozkłada się na ", number, end=", ")

for i in range(2, number):
    while number % i == 0:
        print(i, end=" ")
        number //= i

print()
