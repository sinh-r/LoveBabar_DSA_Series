n = int(input())

i = 1
while i <= n:
    j = i
    while j > 0:
        print(j, end=' ')
        j -= 1
    print()
    i += 1