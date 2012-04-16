﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Steag.Framework.Security
{
    public class MD5Crypto
    {
        private byte[] _salt;
        private int _saltSize = 128;

        public bool SaltHash { get; set; }
        

        public int SaltSize 
        {
            get
            {
                return _saltSize;
            }
            set
            {
                _saltSize = value;
            }
        }

        public byte[] Salt
        {
            get
            { 
                if(Equals(_salt, null))
                {
                    _salt = new byte[SaltSize];
                    var rng = new RNGCryptoServiceProvider();
                    rng.GetNonZeroBytes(_salt); 
                }
                return _salt; 
            }
            set
            {
                _salt = value;
            }            
        }

        public byte[] ComputeHash(byte[] data)
        {
            if (Equals(data, null))
                throw new ArgumentNullException("data");

            if (SaltHash)
                return ComputeHash(data, Salt);
            
            var provider = new MD5CryptoServiceProvider();
            return provider.ComputeHash(data);
        }

        public byte[] ComputeHash(byte[] data, byte[] salt)
        {
            if (Equals(data, null))
                throw new ArgumentNullException("data");

            if (Equals(salt, null))
                throw new ArgumentNullException("salt");

            byte[] dataPlusSalt = new byte[data.Length + salt.Length];
            Array.Copy(data, dataPlusSalt, data.Length);
            Array.Copy(salt, 0, dataPlusSalt, data.Length, salt.Length);
            var provider = new MD5CryptoServiceProvider();
            return provider.ComputeHash(dataPlusSalt);
        }

        public byte[] ComputeHash(Stream stream)
        {
            if (Equals(stream, null))
                throw new ArgumentNullException("stream");

            if (SaltHash)
                return ComputeHash(stream, Salt);
            
            var provider = new MD5CryptoServiceProvider();
            return provider.ComputeHash(stream);
        }

        public byte[] ComputeHash(Stream stream, byte[] salt)
        {
            if (Equals(stream, null))
                throw new ArgumentNullException("stream");

            var data = new byte[stream.Length];
            stream.Read(data, 0, (int)stream.Length - 1);

            return ComputeHash(data, salt);
        }
    }
}
