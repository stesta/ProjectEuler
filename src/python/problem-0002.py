from sequences import fibonacci
from itertools import takewhile

def even(seq):
    for x in seq:
        if x % 2 == 0:
            yield x

print sum(takewhile(lambda x: x < 4000000, even(fibonacci())))
