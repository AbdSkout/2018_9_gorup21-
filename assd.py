z=0
def f(x,y):
    def g(x):
        nonlocal y
        global z
        z=z+1
        y=y+1
        x=x+1
        print("z={0}, y={1}, x={2}".format(z,y,x))
    y=x
    return g
