n = int(input())
s = 0
for i in range(1, n+1):
    if int(input()) == 0:
        s += 1
print(s)