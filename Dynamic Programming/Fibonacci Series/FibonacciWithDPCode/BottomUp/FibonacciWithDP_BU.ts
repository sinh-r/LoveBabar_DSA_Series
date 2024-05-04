class FibWithDP_BU{
    _dp: number[];

    constructor(n: number) {
        this._dp = new Array(n+1);     
    }

    getNthFibonacciNumber = (n: number): number => {
        this._dp[0] = 0;
        this._dp[1] = 1;   

        for(let i:number = 2; i < n+1; i++){
            this._dp[i] = this._dp[i-1] + this._dp[i-2];
        }

        return this._dp[n];
    }
}