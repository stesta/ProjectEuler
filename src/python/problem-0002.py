from sequences import fibonacci
from itertools import takewhile

def even(seq):
    for x in seq:
        if x % 2 == 0:
            yield x

def problem0002():
    return sum(takewhile(lambda x: x < 4000000, even(fibonacci())))

if (__name__ == '__main__'):
    print problem0002()
