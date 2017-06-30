"""A library of useful sequences.

Note:
    many of the 'infinite' sequences work well in conjuction with helper functions like itertools.takewhile
    in the repl you can use list coercion:
        [x for x in takewhile(lambda x: x <= 21, fibonacci())]
"""


def even(seq):
    """Filters by even numbers

    Args:
        seq: a given sequence of integers

    Returns: A filtered list (iterator) of only the even number provided in the sequence
    """
    for x in seq:
        if x % 2 == 0:
            yield x


def fibonacci():
    """The Fibonacci Sequence

    Returns:
        Yields an infinite list (iterator) of values from the fibonacci sequence [1, 1, 2, 3, 5, 8, 13, 21...]
    """
    a, b = 1, 1
    while 1:
        yield a
        a, b = b, a+b
