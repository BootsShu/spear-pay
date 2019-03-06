﻿namespace SpearPay.Alipay.Response
{
    public class ScanPayResponse : AlipayResponse
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 当前预下单请求生成的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码
        /// </summary>
        public string QrCode { get; set; }
    }
}
