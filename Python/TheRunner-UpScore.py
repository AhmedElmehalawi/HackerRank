if __name__ == '__main__':
    n = int(raw_input())
    arr = map(int, raw_input().split())
    
    arr_set = set(arr)                 # in order to remove duplicates.
    sorted_arr = sorted(list(arr_set))    
    print(sorted_arr[-2])
