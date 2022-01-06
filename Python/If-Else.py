#!/bin/python

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(raw_input().strip())
if (n%2!= 0):
    print("Weird")
elif (n in range(2, 6) and n%2 ==0):
    print("Not Weird")
elif (n in range(6, 21) and n%2 ==0):
    print("Weird") 
elif (n in range(21, 101) and n%2 ==0):
    print("Not Weird")       
