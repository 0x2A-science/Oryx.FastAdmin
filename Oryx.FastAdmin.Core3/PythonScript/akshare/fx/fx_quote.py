# -*- coding:utf-8 -*-
# /usr/bin/env python
"""
Author: Albert King
date: 2019/10/20 10:57
contact: jindaxiang@163.com
desc: 获取中国外汇交易中心暨全国银行间同业拆借中心-市场数据-市场行情-外汇市场行情
人民币外汇即期报价: get_fx_spot_quote
人民币外汇远掉报价: get_fx_swap_quote
外币对即期报价: get_fx_pair_quote
"""
import time

import requests
import pandas as pd

from akshare.fx.cons import SHORT_HEADERS, FX_SPOT_URL, FX_SWAP_URL, FX_PAIR_URL


def fx_spot_quote():
    """
    中国外汇交易中心暨全国银行间同业拆借中心-市场数据-市场行情-外汇市场行情-人民币外汇即期报价
    :return: pandas.DataFrame
               ccyPair   bidPrc   askPrc midprice time
    0      USD/CNY   7.0810   7.0824      ---
    1      EUR/CNY   7.8878   7.8903      ---
    2   100JPY/CNY   6.5252   6.5275      ---
    3      HKD/CNY  0.90293  0.90316      ---
    4      GBP/CNY   9.1140   9.1181      ---
    5      AUD/CNY   4.8472   4.8491      ---
    6      NZD/CNY   4.5151   4.5172      ---
    7      SGD/CNY   5.1878   5.1897      ---
    8      CHF/CNY   7.1810   7.1838      ---
    9      CAD/CNY   5.3911   5.3929      ---
    10     CNY/MYR  0.58726  0.59527      ---
    11     CNY/RUB   9.0363   9.0489      ---
    12     CNY/ZAR   2.0883   2.0923      ---
    13     CNY/KRW   166.55   166.89      ---
    14     CNY/AED  0.51850  0.51886      ---
    15     CNY/SAR  0.52949  0.52979      ---
    16     CNY/HUF  41.8886  41.9805      ---
    17     CNY/PLN  0.54270  0.54331      ---
    18     CNY/DKK   0.9468   0.9473      ---
    19     CNY/SEK   1.3660   1.3667      ---
    20     CNY/NOK   1.2964   1.2971      ---
    21     CNY/TRY  0.81723  0.81918      ---
    22     CNY/MXN   2.7016   2.7041      ---
    23     CNY/THB   4.2753   4.2791      ---
    """
    payload = {"t": str(int(round(time.time() * 1000)))}
    res = requests.post(FX_SPOT_URL, data=payload, headers=SHORT_HEADERS)
    return pd.DataFrame(res.json()["records"])


def fx_swap_quote():
    """
    中国外汇交易中心暨全国银行间同业拆借中心-市场数据-市场行情-债券市场行情-人民币外汇远掉报价
    :return: pandas.DataFrame
            ccpair         label_1W         label_1M           label_3M  \
    0      USD/CNY      11.50/12.00      46.00/46.00      125.00/125.00
    1      EUR/CNY      51.90/52.12    218.17/218.56      658.41/658.56
    2   100JPY/CNY      40.03/40.13    177.78/177.83      530.98/531.17
    3      HKD/CNY        2.15/2.17        8.24/8.52        20.48/20.53
    4      GBP/CNY      37.65/37.87    150.56/150.58      445.90/446.01
    5      AUD/CNY      16.57/16.65      70.49/70.58      203.26/203.75
    6      NZD/CNY      16.07/16.22      60.94/61.58      168.29/169.03
    7      SGD/CNY      12.05/12.45      50.49/50.84      144.87/146.50
    8      CHF/CNY      51.31/52.25    218.56/218.56      675.03/675.18
    9      CAD/CNY      12.28/12.28      47.65/47.69      138.33/138.46
    10     CNY/MYR       -0.30/0.17       -0.24/0.61        -2.38/-0.84
    11     CNY/RUB      67.89/73.27    296.66/320.03      882.24/899.51
    12     CNY/ZAR      15.55/16.41      72.06/72.70      213.92/215.87
    13     CNY/KRW      -6.77/-3.84    -29.85/-15.77      -90.62/-52.66
    14     CNY/AED      -0.90/-0.70      -3.38/-2.96        -8.08/-7.46
    15     CNY/SAR      -1.31/-1.14      -4.81/-4.27       -10.27/-9.88
    16     CNY/HUF  -247.54/-213.70  -938.77/-908.44  -2937.98/-2827.36
    17     CNY/PLN      -1.50/-1.37      -5.52/-5.32      -14.85/-14.02
    18     CNY/DKK      -6.88/-6.74    -28.61/-28.13      -87.29/-83.40
    19     CNY/SEK      -8.83/-8.25    -34.51/-33.83    -104.48/-100.71
    20     CNY/NOK      -3.94/-2.84    -13.58/-11.24      -34.81/-33.72
    21     CNY/TRY      13.47/22.01     56.52/103.43      229.52/242.35
    22     CNY/MXN      -4.58/-4.40    -17.57/-17.57      -47.68/-46.55
    23     CNY/THB      -7.25/-6.87    -27.77/-27.72      -75.46/-75.42
                 label_6M           label_9M           label_1Y
    0       205.00/210.00      275.00/278.00      342.50/345.00
    1     1199.68/1201.39    1723.92/1730.71    2246.18/2249.27
    2       963.67/967.95    1402.82/1403.96    1793.50/1801.90
    3         32.31/32.67        40.96/40.96        48.84/49.03
    4       763.21/769.97    1052.69/1054.22    1336.20/1338.15
    5       364.81/364.87      499.29/502.99      623.56/627.52
    6       297.93/301.14      404.95/407.30      517.50/519.69
    7       257.36/259.91      341.81/346.18      427.37/428.44
    8     1237.70/1241.00    1770.44/1774.84    2310.22/2311.93
    9       195.51/199.29      231.22/231.30      263.39/263.40
    10          2.66/5.88        10.64/19.33        20.53/33.38
    11    1780.84/1814.49    2697.91/2759.32    3604.59/3663.77
    12      440.35/442.99      676.02/682.94      919.59/923.42
    13    -167.44/-110.12    -233.82/-171.47    -304.06/-233.52
    14      -13.13/-11.45      -15.97/-14.44      -18.74/-17.22
    15      -15.74/-15.13      -19.89/-18.33      -22.75/-21.21
    16  -5168.11/-4910.26  -7171.99/-6800.90  -9438.87/-8728.19
    17      -23.17/-21.13      -27.96/-25.45      -32.19/-28.86
    18    -158.56/-152.01    -225.33/-216.64    -290.38/-278.70
    19    -180.36/-177.42    -250.27/-248.86    -318.80/-305.83
    20      -50.00/-47.44      -60.16/-56.10      -70.53/-60.84
    21      436.90/494.04      651.61/750.10      895.51/993.76
    22      -79.94/-78.15    -105.72/-104.72    -131.06/-130.29
    23    -126.90/-123.92    -168.07/-166.21    -208.66/-207.02
    """
    payload = {"t": str(int(round(time.time() * 1000)))}
    res = requests.post(FX_SWAP_URL, data=payload, headers=SHORT_HEADERS)
    return pd.DataFrame(res.json()["records"])


def fx_pair_quote():
    """
    中国外汇交易中心暨全国银行间同业拆借中心-市场数据-市场行情-债券市场行情-外币对即期报价
    :return: pandas.DataFrame
            ccyPair   bidPrc   askPrc midprice time
    0   AUD/USD  0.68460  0.68461      ---
    1   EUR/JPY  120.897  120.898      ---
    2   EUR/USD  1.11402  1.11403      ---
    3   GBP/USD  1.28724  1.28727      ---
    4   USD/CAD  1.31339  1.31340      ---
    5   USD/CHF  0.98599  0.98601      ---
    6   USD/HKD  7.84215  7.84217      ---
    7   USD/JPY  108.516  108.517      ---
    8   USD/SGD  1.36483  1.36485      ---
    9   NZD/USD  0.63772  0.63773      ---
    10  EUR/GBP  0.86544  0.86546      ---
    """
    payload = {"t": str(int(round(time.time() * 1000)))}
    res = requests.post(FX_PAIR_URL, data=payload, headers=SHORT_HEADERS)
    return pd.DataFrame(res.json()["records"])


if __name__ == "__main__":
    df = fx_spot_quote()
    print(df)
    df = fx_swap_quote()
    print(df)
    df = fx_pair_quote()
    print(df)
