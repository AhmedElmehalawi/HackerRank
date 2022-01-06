# Complete the solve function below.
def solve(s):
    for i in s.split():
        s = s.replace(i,i.capitalize())
    return s

'''
def anotherSolve(s):    
    titled_s = s.title()
    return titled_s
'''

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = raw_input()

    result = solve(s)

    fptr.write(result + '\n')

    fptr.close()
