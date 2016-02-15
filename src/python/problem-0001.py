def problem0001():
    domain = (x for x in range(1000) if x % 3 == 0 or x % 5 == 0)
    answer = sum (domain)
    return answer

if (__name__ == '__main__'):
    print problem0001()
