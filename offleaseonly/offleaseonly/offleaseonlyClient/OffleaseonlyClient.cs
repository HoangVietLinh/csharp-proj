﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Microsoft.Rest;
using Offleaseonly;

namespace Offleaseonly
{
    public partial class OffleaseonlyClient : ServiceClient<OffleaseonlyClient>, IOffleaseonlyClient
    {
        private Uri _baseUri;
        
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }
        
        private ServiceClientCredentials _credentials;
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }
        
        private ICarOperations _car;
        
        public virtual ICarOperations Car
        {
            get { return this._car; }
        }
        
        private ICars _cars;
        
        public virtual ICars Cars
        {
            get { return this._cars; }
        }
        
        private IScrape _scrape;
        
        public virtual IScrape Scrape
        {
            get { return this._scrape; }
        }
        
        private IStats _stats;
        
        public virtual IStats Stats
        {
            get { return this._stats; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        public OffleaseonlyClient()
            : base()
        {
            this._car = new CarOperations(this);
            this._cars = new Cars(this);
            this._scrape = new Scrape(this);
            this._stats = new Stats(this);
            this._baseUri = new Uri("http://offleaseonly.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public OffleaseonlyClient(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._car = new CarOperations(this);
            this._cars = new Cars(this);
            this._scrape = new Scrape(this);
            this._stats = new Stats(this);
            this._baseUri = new Uri("http://offleaseonly.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public OffleaseonlyClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._car = new CarOperations(this);
            this._cars = new Cars(this);
            this._scrape = new Scrape(this);
            this._stats = new Stats(this);
            this._baseUri = new Uri("http://offleaseonly.azurewebsites.net");
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public OffleaseonlyClient(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public OffleaseonlyClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the OffleaseonlyClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public OffleaseonlyClient(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;
            
            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}
