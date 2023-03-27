li = int(input())
prime = 1
for i in range(2, li):
    if li % i == 0:
        prime = 0
        break
        
if prime == 1:
    print("jest liczbą pierwsza")

else:
    print(li, "liczba nie jest pierwsza")
