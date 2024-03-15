# mandelbrot_cy.pyx

cdef extern from "complex.h":
    double cabs(double complex)

cdef inline double complex c_square(double complex c):
    return c * c

cpdef int mandelbrot(double complex c, int max_iter):
    cdef double complex z = 0
    cdef int n = 0
    while cabs(z) <= 2 and n < max_iter:
        z = c_square(z) + c
        n += 1
    return n
