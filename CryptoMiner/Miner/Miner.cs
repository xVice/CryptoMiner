using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CryptoMiner.Wallet;

namespace CryptoMiner.Miner
{
    public class Miner
    {
        public Wallet.Wallet wallet { get; set; }
        public bool isMining { get; set; }

        private int hashRate;
        public double hashes = 0.000000;
        private Thread miningThread;

        public Miner(Wallet.Wallet wallet, int hashRate)
        {
            this.wallet = wallet;
            this.hashRate = hashRate;
        }

        private async void MiningThread()
        {
            while (true)
            {
                if(hashes > 1200)
                {
                    hashes = 0;
                    wallet.coins += 0.000001;
                }
                if(isMining)
                {
                    await MineCoin();
                }
            }
        }

        private Task MineCoin()
        {
            hashes += hashRate;
            Task.Delay(1000); //gamepleay design!
            return Task.CompletedTask;
        }

        public void StartMiner()
        {
            isMining = true;
            miningThread = new Thread(new ThreadStart(MiningThread));
        }

        public void StopMiner()
        {
            isMining = false;
            miningThread.Abort();
        }
    }
}
