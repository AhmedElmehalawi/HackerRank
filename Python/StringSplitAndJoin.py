def split_and_join(line):
    # write your code here
    splittedLine = line.split(" ")
    joinedLine = "-".join(splittedLine)
    return joinedLine

if __name__ == '__main__':
    line = raw_input()
    result = split_and_join(line)
    print result
