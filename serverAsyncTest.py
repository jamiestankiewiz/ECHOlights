import socket
import time
import argparse
import pdb
import asyncio

async def count(y):
    for i in range(y):
        print(str(i))
        await asyncio.sleep(0.01)
    return None

async def count2(y):
    for i in range(y):
        print(str(i*2))
        await asyncio.sleep(0.01)
    return None

async def main():
  a = asyncio.create_task(count(10))
  b = asyncio.create_task(count(15))  
    # await asyncio.wait([
    #     count(10),
    #     count2(10)
    # ])
  await a,b
  # print('ef')


if __name__ == "__main__": 
    asyncio.run(main())