// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.AdExchangeBuyer.v1_3
{
    /// <summary>The AdExchangeBuyer Service.</summary>
    public class AdExchangeBuyerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1.3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AdExchangeBuyerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AdExchangeBuyerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            BillingInfo = new BillingInfoResource(this);
            Budget = new BudgetResource(this);
            Creatives = new CreativesResource(this);
            DirectDeals = new DirectDealsResource(this);
            PerformanceReport = new PerformanceReportResource(this);
            PretargetingConfig = new PretargetingConfigResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "adexchangebuyer";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/adexchangebuyer/v1.3/";
        #else
            "https://www.googleapis.com/adexchangebuyer/v1.3/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "adexchangebuyer/v1.3/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/adexchangebuyer/v1.3";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/adexchangebuyer/v1.3";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Ad Exchange Buyer API.</summary>
        public class Scope
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public static string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Ad Exchange Buyer API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Manage your Ad Exchange buyer account configuration</summary>
            public const string AdexchangeBuyer = "https://www.googleapis.com/auth/adexchange.buyer";

        }



        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the BillingInfo resource.</summary>
        public virtual BillingInfoResource BillingInfo { get; }

        /// <summary>Gets the Budget resource.</summary>
        public virtual BudgetResource Budget { get; }

        /// <summary>Gets the Creatives resource.</summary>
        public virtual CreativesResource Creatives { get; }

        /// <summary>Gets the DirectDeals resource.</summary>
        public virtual DirectDealsResource DirectDeals { get; }

        /// <summary>Gets the PerformanceReport resource.</summary>
        public virtual PerformanceReportResource PerformanceReport { get; }

        /// <summary>Gets the PretargetingConfig resource.</summary>
        public virtual PretargetingConfigResource PretargetingConfig { get; }
    }

    /// <summary>A base abstract class for AdExchangeBuyer requests.</summary>
    public abstract class AdExchangeBuyerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AdExchangeBuyerBaseServiceRequest instance.</summary>
        protected AdExchangeBuyerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes AdExchangeBuyer parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("userIp", new Google.Apis.Discovery.Parameter
            {
                Name = "userIp",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets one account by ID.</summary>
        /// <param name="id">The account id</param>
        public virtual GetRequest Get(int id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>Gets one account by ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Account>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int id) : base(service)
            {
                Id = id;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves the authenticated user's list of accounts.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.AccountsList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_3.Data.Account body, int id)
        {
            return new PatchRequest(service, body, id);
        }

        /// <summary>Updates an existing account. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Account>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.Account body, int id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an existing account.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="id">The account id</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_3.Data.Account body, int id)
        {
            return new UpdateRequest(service, body, id);
        }

        /// <summary>Updates an existing account.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Account>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.Account body, int id) : base(service)
            {
                Id = id;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int Id { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.Account Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "accounts/{id}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "billingInfo" collection of methods.</summary>
    public class BillingInfoResource
    {
        private const string Resource = "billingInfo";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BillingInfoResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns the billing information for one account specified by account ID.</summary>
        /// <param name="accountId">The account id.</param>
        public virtual GetRequest Get(int accountId)
        {
            return new GetRequest(service, accountId);
        }

        /// <summary>Returns the billing information for one account specified by account ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.BillingInfo>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The account id.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves a list of billing information for all accounts of the authenticated user.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves a list of billing information for all accounts of the authenticated user.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.BillingInfoList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }

    /// <summary>The "budget" collection of methods.</summary>
    public class BudgetResource
    {
        private const string Resource = "budget";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public BudgetResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Returns the budget information for the adgroup specified by the accountId and billingId.</summary>
        /// <param name="accountId">The account id to get the budget information for.</param>
        /// <param
        /// name="billingId">The billing id to get the budget information for.</param>
        public virtual GetRequest Get(long accountId, long billingId)
        {
            return new GetRequest(service, accountId, billingId);
        }

        /// <summary>Returns the budget information for the adgroup specified by the accountId and billingId.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Budget>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                InitParameters();
            }


            /// <summary>The account id to get the budget information for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id to get the budget information for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates the budget amount for the budget of the adgroup specified by the accountId and billingId,
        /// with the budget amount in the request. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param
        /// name="billingId">The billing id associated with the budget being updated.</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_3.Data.Budget body, long accountId, long billingId)
        {
            return new PatchRequest(service, body, accountId, billingId);
        }

        /// <summary>Updates the budget amount for the budget of the adgroup specified by the accountId and billingId,
        /// with the budget amount in the request. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Budget>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.Budget body, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.Budget Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates the budget amount for the budget of the adgroup specified by the accountId and billingId,
        /// with the budget amount in the request.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id associated with the budget being updated.</param>
        /// <param
        /// name="billingId">The billing id associated with the budget being updated.</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_3.Data.Budget body, long accountId, long billingId)
        {
            return new UpdateRequest(service, body, accountId, billingId);
        }

        /// <summary>Updates the budget amount for the budget of the adgroup specified by the accountId and billingId,
        /// with the budget amount in the request.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Budget>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.Budget body, long accountId, long billingId) : base(service)
            {
                AccountId = accountId;
                BillingId = billingId;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The billing id associated with the budget being updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("billingId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long BillingId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.Budget Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "billinginfo/{accountId}/{billingId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("billingId", new Google.Apis.Discovery.Parameter
                {
                    Name = "billingId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "creatives" collection of methods.</summary>
    public class CreativesResource
    {
        private const string Resource = "creatives";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CreativesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets the status for a single creative. A creative will be available 30-40 minutes after
        /// submission.</summary>
        /// <param name="accountId">The id for the account that will serve this creative.</param>
        /// <param
        /// name="buyerCreativeId">The buyer-specific id for this creative.</param>
        public virtual GetRequest Get(int accountId, string buyerCreativeId)
        {
            return new GetRequest(service, accountId, buyerCreativeId);
        }

        /// <summary>Gets the status for a single creative. A creative will be available 30-40 minutes after
        /// submission.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Creative>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, int accountId, string buyerCreativeId) : base(service)
            {
                AccountId = accountId;
                BuyerCreativeId = buyerCreativeId;
                InitParameters();
            }


            /// <summary>The id for the account that will serve this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int AccountId { get; private set; }

            /// <summary>The buyer-specific id for this creative.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string BuyerCreativeId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives/{accountId}/{buyerCreativeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Submit a new creative.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_3.Data.Creative body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Submit a new creative.</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.Creative>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.Creative body) : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.Creative Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40
        /// minutes after submission.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves a list of the authenticated user's active creatives. A creative will be available 30-40
        /// minutes after submission.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.CreativesList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }


            /// <summary>When specified, only creatives for the given account ids are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AccountId { get; set; }

            /// <summary>When specified, only creatives for the given buyer creative ids are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("buyerCreativeId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> BuyerCreativeId { get; set; }

            /// <summary>Maximum number of entries returned on one result page. If not set, the default is 100.
            /// Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>A continuation token, used to page through ad clients. To retrieve the next page, set this
            /// parameter to the value of "nextPageToken" from the previous response. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>When specified, only creatives having the given status are returned.</summary>
            [Google.Apis.Util.RequestParameterAttribute("statusFilter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<StatusFilterEnum> StatusFilter { get; set; }

            /// <summary>When specified, only creatives having the given status are returned.</summary>
            public enum StatusFilterEnum
            {
                /// <summary>Creatives which have been approved.</summary>
                [Google.Apis.Util.StringValueAttribute("approved")]
                Approved,
                /// <summary>Creatives which have been disapproved.</summary>
                [Google.Apis.Util.StringValueAttribute("disapproved")]
                Disapproved,
                /// <summary>Creatives whose status is not yet checked.</summary>
                [Google.Apis.Util.StringValueAttribute("not_checked")]
                NotChecked,
            }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "creatives";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("buyerCreativeId", new Google.Apis.Discovery.Parameter
                {
                    Name = "buyerCreativeId",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("statusFilter", new Google.Apis.Discovery.Parameter
                {
                    Name = "statusFilter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "directDeals" collection of methods.</summary>
    public class DirectDealsResource
    {
        private const string Resource = "directDeals";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DirectDealsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Gets one direct deal by ID.</summary>
        /// <param name="id">The direct deal id</param>
        public virtual GetRequest Get(long id)
        {
            return new GetRequest(service, id);
        }

        /// <summary>Gets one direct deal by ID.</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.DirectDeal>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long id) : base(service)
            {
                Id = id;
                InitParameters();
            }


            /// <summary>The direct deal id</summary>
            [Google.Apis.Util.RequestParameterAttribute("id", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long Id { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "directdeals/{id}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("id", new Google.Apis.Discovery.Parameter
                {
                    Name = "id",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves the authenticated user's list of direct deals.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieves the authenticated user's list of direct deals.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.DirectDealsList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }



            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "directdeals";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }

    /// <summary>The "performanceReport" collection of methods.</summary>
    public class PerformanceReportResource
    {
        private const string Resource = "performanceReport";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PerformanceReportResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves the authenticated user's list of performance metrics.</summary>
        /// <param name="accountId">The account id to get the reports.</param>
        /// <param name="endDateTime">The end time of
        /// the report in ISO 8601 timestamp format using UTC.</param>
        /// <param name="startDateTime">The start time of the
        /// report in ISO 8601 timestamp format using UTC.</param>
        public virtual ListRequest List(long accountId, string endDateTime, string startDateTime)
        {
            return new ListRequest(service, accountId, endDateTime, startDateTime);
        }

        /// <summary>Retrieves the authenticated user's list of performance metrics.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PerformanceReportList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, long accountId, string endDateTime, string startDateTime) : base(service)
            {
                AccountId = accountId;
                EndDateTime = endDateTime;
                StartDateTime = startDateTime;
                InitParameters();
            }


            /// <summary>The account id to get the reports.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual long AccountId { get; private set; }

            /// <summary>The end time of the report in ISO 8601 timestamp format using UTC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endDateTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string EndDateTime { get; private set; }

            /// <summary>The start time of the report in ISO 8601 timestamp format using UTC.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startDateTime", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string StartDateTime { get; private set; }

            /// <summary>Maximum number of entries returned on one result page. If not set, the default is 100.
            /// Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<long> MaxResults { get; set; }

            /// <summary>A continuation token, used to page through performance reports. To retrieve the next page, set
            /// this parameter to the value of "nextPageToken" from the previous response. Optional.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "performancereport";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("endDateTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "endDateTime",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("startDateTime", new Google.Apis.Discovery.Parameter
                {
                    Name = "startDateTime",
                    IsRequired = true,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("maxResults", new Google.Apis.Discovery.Parameter
                {
                    Name = "maxResults",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }

    /// <summary>The "pretargetingConfig" collection of methods.</summary>
    public class PretargetingConfigResource
    {
        private const string Resource = "pretargetingConfig";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PretargetingConfigResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes an existing pretargeting config.</summary>
        /// <param name="accountId">The account id to delete the pretargeting config for.</param>
        /// <param
        /// name="configId">The specific id of the configuration to delete.</param>
        public virtual DeleteRequest Delete(long accountId, long configId)
        {
            return new DeleteRequest(service, accountId, configId);
        }

        /// <summary>Deletes an existing pretargeting config.</summary>
        public class DeleteRequest : AdExchangeBuyerBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                InitParameters();
            }


            /// <summary>The account id to delete the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to delete.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Gets a specific pretargeting configuration</summary>
        /// <param name="accountId">The account id to get the pretargeting config for.</param>
        /// <param
        /// name="configId">The specific id of the configuration to retrieve.</param>
        public virtual GetRequest Get(long accountId, long configId)
        {
            return new GetRequest(service, accountId, configId);
        }

        /// <summary>Gets a specific pretargeting configuration</summary>
        public class GetRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                InitParameters();
            }


            /// <summary>The account id to get the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to retrieve.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Inserts a new pretargeting configuration.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to insert the pretargeting config for.</param>
        public virtual InsertRequest Insert(Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId)
        {
            return new InsertRequest(service, body, accountId);
        }

        /// <summary>Inserts a new pretargeting configuration.</summary>
        public class InsertRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId) : base(service)
            {
                AccountId = accountId;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id to insert the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Retrieves a list of the authenticated user's pretargeting configurations.</summary>
        /// <param name="accountId">The account id to get the pretargeting configs for.</param>
        public virtual ListRequest List(long accountId)
        {
            return new ListRequest(service, accountId);
        }

        /// <summary>Retrieves a list of the authenticated user's pretargeting configurations.</summary>
        public class ListRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfigList>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, long accountId) : base(service)
            {
                AccountId = accountId;
                InitParameters();
            }


            /// <summary>The account id to get the pretargeting configs for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }


            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an existing pretargeting config. This method supports patch semantics.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param
        /// name="configId">The specific id of the configuration to update.</param>
        public virtual PatchRequest Patch(Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId, long configId)
        {
            return new PatchRequest(service, body, accountId, configId);
        }

        /// <summary>Updates an existing pretargeting config. This method supports patch semantics.</summary>
        public class PatchRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id to update the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }

        /// <summary>Updates an existing pretargeting config.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="accountId">The account id to update the pretargeting config for.</param>
        /// <param
        /// name="configId">The specific id of the configuration to update.</param>
        public virtual UpdateRequest Update(Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId, long configId)
        {
            return new UpdateRequest(service, body, accountId, configId);
        }

        /// <summary>Updates an existing pretargeting config.</summary>
        public class UpdateRequest : AdExchangeBuyerBaseServiceRequest<Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig body, long accountId, long configId) : base(service)
            {
                AccountId = accountId;
                ConfigId = configId;
                Body = body;
                InitParameters();
            }


            /// <summary>The account id to update the pretargeting config for.</summary>
            [Google.Apis.Util.RequestParameterAttribute("accountId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long AccountId { get; private set; }

            /// <summary>The specific id of the configuration to update.</summary>
            [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual long ConfigId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AdExchangeBuyer.v1_3.Data.PretargetingConfig Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "update";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "pretargetingconfigs/{accountId}/{configId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add("accountId", new Google.Apis.Discovery.Parameter
                {
                    Name = "accountId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                {
                    Name = "configId",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = null,
                });
            }

        }
    }
}

namespace Google.Apis.AdExchangeBuyer.v1_3.Data
{    

    /// <summary>Configuration data for an Ad Exchange buyer account.</summary>
    public class Account : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Your bidder locations that have distinct URLs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidderLocation")]
        public virtual System.Collections.Generic.IList<Account.BidderLocationData> BidderLocation { get; set; } 

        /// <summary>The nid parameter value used in cookie match requests. Please contact your technical account
        /// manager if you need to change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingNid")]
        public virtual string CookieMatchingNid { get; set; } 

        /// <summary>The base URL used in cookie match requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatchingUrl")]
        public virtual string CookieMatchingUrl { get; set; } 

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<int> Id { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The maximum number of active creatives that an account can have, where a creative is active if it
        /// was inserted or bid with in the last 30 days. Please contact your technical account manager if you need to
        /// change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumActiveCreatives")]
        public virtual System.Nullable<int> MaximumActiveCreatives { get; set; } 

        /// <summary>The sum of all bidderLocation.maximumQps values cannot exceed this. Please contact your technical
        /// account manager if you need to change this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumTotalQps")]
        public virtual System.Nullable<int> MaximumTotalQps { get; set; } 

        /// <summary>The number of creatives that this account inserted or bid with in the last 30 days.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberActiveCreatives")]
        public virtual System.Nullable<int> NumberActiveCreatives { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class BidderLocationData
        {
            /// <summary>The maximum queries per second the Ad Exchange will send.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
            public virtual System.Nullable<int> MaximumQps { get; set; } 

            /// <summary>The geographical region the Ad Exchange should send requests from. Only used by some quota
            /// systems, but always setting the value is recommended. Allowed values: - ASIA - EUROPE - US_EAST -
            /// US_WEST</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("region")]
            public virtual string Region { get; set; } 

            /// <summary>The URL to which the Ad Exchange will send bid requests.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("url")]
            public virtual string Url { get; set; } 

        }
    }    

    /// <summary>An account feed lists Ad Exchange buyer accounts that the user has access to. Each entry in the feed
    /// corresponds to a single buyer account.</summary>
    public class AccountsList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of accounts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Account> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration data for an Ad Exchange billing info.</summary>
    public class BillingInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; } 

        /// <summary>Account name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountName")]
        public virtual string AccountName { get; set; } 

        /// <summary>A list of adgroup IDs associated with this particular account. These IDs may show up as part of a
        /// realtime bidding BidRequest, which indicates a bid request for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Collections.Generic.IList<string> BillingId { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A billing info feed lists Billing Info the Ad Exchange buyer account has access to. Each entry in the
    /// feed corresponds to a single billing info.</summary>
    public class BillingInfoList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of billing info relevant for your account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<BillingInfo> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration data for Ad Exchange RTB - Budget API.</summary>
    public class Budget : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id of the account. This is required for get and update requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<long> AccountId { get; set; } 

        /// <summary>The billing id to determine which adgroup to provide budget information for. This is required for
        /// get and update requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Nullable<long> BillingId { get; set; } 

        /// <summary>The daily budget amount in unit amount of the account currency to apply for the billingId provided.
        /// This is required for update requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("budgetAmount")]
        public virtual System.Nullable<long> BudgetAmount { get; set; } 

        /// <summary>The currency code for the buyer. This cannot be altered here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; } 

        /// <summary>The unique id that describes this item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>The kind of the resource, i.e. "adexchangebuyer#budget".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A creative and its classification data.</summary>
    public class Creative : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The HTML snippet that displays the ad when inserted in the web page. If set, videoURL should not be
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("HTMLSnippet")]
        public virtual string HTMLSnippet { get; set; } 

        /// <summary>Account id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("adTechnologyProviders")]
        public virtual Creative.AdTechnologyProvidersData AdTechnologyProviders { get; set; } 

        /// <summary>Detected advertiser id, if any. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserId")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> AdvertiserId { get; set; } 

        /// <summary>The name of the company being advertised in the creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiserName")]
        public virtual string AdvertiserName { get; set; } 

        /// <summary>The agency id for this creative.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agencyId")]
        public virtual System.Nullable<long> AgencyId { get; set; } 

        /// <summary>The last upload timestamp of this creative if it was uploaded via API. Read-only. The value of this
        /// field is generated, and will be ignored for uploads. (formatted RFC 3339 timestamp).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiUploadTimestamp")]
        public virtual string ApiUploadTimestampRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ApiUploadTimestampRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.Nullable<System.DateTime> ApiUploadTimestamp
        {
            get => Google.Apis.Util.Utilities.GetDateTimeFromString(ApiUploadTimestampRaw);
            set => ApiUploadTimestampRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
        }

        /// <summary>All attributes for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attribute")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> Attribute { get; set; } 

        /// <summary>A buyer-specific id identifying the creative in this ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerCreativeId")]
        public virtual string BuyerCreativeId { get; set; } 

        /// <summary>The set of destination urls for the snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clickThroughUrl")]
        public virtual System.Collections.Generic.IList<string> ClickThroughUrl { get; set; } 

        /// <summary>Shows any corrections that were applied to this creative. Read-only. This field should not be set
        /// in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("corrections")]
        public virtual System.Collections.Generic.IList<Creative.CorrectionsData> Corrections { get; set; } 

        /// <summary>The reasons for disapproval, if any. Note that not all disapproval reasons may be categorized, so
        /// it is possible for the creative to have a status of DISAPPROVED with an empty list for disapproval_reasons.
        /// In this case, please reach out to your TAM to help debug the issue. Read-only. This field should not be set
        /// in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disapprovalReasons")]
        public virtual System.Collections.Generic.IList<Creative.DisapprovalReasonsData> DisapprovalReasons { get; set; } 

        /// <summary>The filtering reasons for the creative. Read-only. This field should not be set in
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteringReasons")]
        public virtual Creative.FilteringReasonsData FilteringReasons { get; set; } 

        /// <summary>Ad height.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; } 

        /// <summary>The set of urls to be called to record an impression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrl")]
        public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrl { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>If nativeAd is set, HTMLSnippet and videoURL should not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeAd")]
        public virtual Creative.NativeAdData NativeAd { get; set; } 

        /// <summary>Detected product categories, if any. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("productCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> ProductCategories { get; set; } 

        /// <summary>All restricted categories for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> RestrictedCategories { get; set; } 

        /// <summary>Detected sensitive categories, if any. Read-only. This field should not be set in
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sensitiveCategories")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> SensitiveCategories { get; set; } 

        /// <summary>Creative serving status. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>All vendor types for the ads that may be shown from this snippet.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorType")]
        public virtual System.Collections.Generic.IList<System.Nullable<int>> VendorType { get; set; } 

        /// <summary>The version for this creative. Read-only. This field should not be set in requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

        /// <summary>The URL to fetch a video ad. If set, HTMLSnippet and the nativeAd should not be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("videoURL")]
        public virtual string VideoURL { get; set; } 

        /// <summary>Ad width.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class AdTechnologyProvidersData
        {
            /// <summary>The detected ad technology provider IDs for this creative. See https://storage.googleapis.com
            /// /adx-rtb-dictionaries/providers.csv for mapping of provider ID to provided name, a privacy policy URL,
            /// and a list of domains which can be attributed to the provider. If this creative contains provider IDs
            /// that are outside of those listed in the
            /// `BidRequest.adslot.consented_providers_settings.consented_providers` field on the  Authorized Buyers
            /// Real-Time Bidding protocol or the `BidRequest.user.ext.consented_providers_settings.consented_providers`
            /// field on the OpenRTB protocol, a bid submitted for a European Economic Area (EEA) user with this
            /// creative is not compliant with the GDPR policies as mentioned in the "Third-party Ad Technology Vendors"
            /// section of Authorized Buyers Program Guidelines.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("detectedProviderIds")]
            public virtual System.Collections.Generic.IList<System.Nullable<long>> DetectedProviderIds { get; set; } 

            /// <summary>Whether the creative contains an unidentified ad technology provider. If true, a bid submitted
            /// for a European Economic Area (EEA) user with this creative is not compliant with the GDPR policies as
            /// mentioned in the "Third-party Ad Technology Vendors" section of Authorized Buyers Program
            /// Guidelines.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("hasUnidentifiedProvider")]
            public virtual System.Nullable<bool> HasUnidentifiedProvider { get; set; } 

        }    

        public class CorrectionsData
        {
            /// <summary>Additional details about the correction.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("details")]
            public virtual System.Collections.Generic.IList<string> Details { get; set; } 

            /// <summary>The type of correction that was applied to the creative.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; } 

        }    

        public class DisapprovalReasonsData
        {
            /// <summary>Additional details about the reason for disapproval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("details")]
            public virtual System.Collections.Generic.IList<string> Details { get; set; } 

            /// <summary>The categorized reason for disapproval.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reason")]
            public virtual string Reason { get; set; } 

        }    

        /// <summary>The filtering reasons for the creative. Read-only. This field should not be set in
        /// requests.</summary>
        public class FilteringReasonsData
        {
            /// <summary>The date in ISO 8601 format for the data. The data is collected from 00:00:00 to 23:59:59 in
            /// PST.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; } 

            /// <summary>The filtering reasons.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reasons")]
            public virtual System.Collections.Generic.IList<FilteringReasonsData.ReasonsData> Reasons { get; set; } 

            

            public class ReasonsData
            {
                /// <summary>The number of times the creative was filtered for the status. The count is aggregated
                /// across all publishers on the exchange.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringCount")]
                public virtual System.Nullable<long> FilteringCount { get; set; } 

                /// <summary>The filtering status code. Please refer to the creative-status-codes.txt file for different
                /// statuses.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("filteringStatus")]
                public virtual System.Nullable<int> FilteringStatus { get; set; } 

            }
        }    

        /// <summary>If nativeAd is set, HTMLSnippet and videoURL should not be set.</summary>
        public class NativeAdData
        {
            [Newtonsoft.Json.JsonPropertyAttribute("advertiser")]
            public virtual string Advertiser { get; set; } 

            /// <summary>The app icon, for app download ads.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("appIcon")]
            public virtual NativeAdData.AppIconData AppIcon { get; set; } 

            /// <summary>A long description of the ad.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("body")]
            public virtual string Body { get; set; } 

            /// <summary>A label for the button that the user is supposed to click.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callToAction")]
            public virtual string CallToAction { get; set; } 

            /// <summary>The URL to use for click tracking.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("clickTrackingUrl")]
            public virtual string ClickTrackingUrl { get; set; } 

            /// <summary>A short title for the ad.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("headline")]
            public virtual string Headline { get; set; } 

            /// <summary>A large image.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("image")]
            public virtual NativeAdData.ImageData Image { get; set; } 

            /// <summary>The URLs are called when the impression is rendered.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("impressionTrackingUrl")]
            public virtual System.Collections.Generic.IList<string> ImpressionTrackingUrl { get; set; } 

            /// <summary>A smaller image, for the advertiser logo.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("logo")]
            public virtual NativeAdData.LogoData Logo { get; set; } 

            /// <summary>The price of the promoted app including the currency info.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("price")]
            public virtual string Price { get; set; } 

            /// <summary>The app rating in the app store. Must be in the range [0-5].</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("starRating")]
            public virtual System.Nullable<double> StarRating { get; set; } 

            

            /// <summary>The app icon, for app download ads.</summary>
            public class AppIconData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; } 

            }    

            /// <summary>A large image.</summary>
            public class ImageData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; } 

            }    

            /// <summary>A smaller image, for the advertiser logo.</summary>
            public class LogoData
            {
                [Newtonsoft.Json.JsonPropertyAttribute("height")]
                public virtual System.Nullable<int> Height { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("url")]
                public virtual string Url { get; set; } 

                [Newtonsoft.Json.JsonPropertyAttribute("width")]
                public virtual System.Nullable<int> Width { get; set; } 

            }
        }
    }    

    /// <summary>The creatives feed lists the active creatives for the Ad Exchange buyer accounts that the user has
    /// access to. Each entry in the feed corresponds to a single creative.</summary>
    public class CreativesList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of creatives.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Creative> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Continuation token used to page through creatives. To retrieve the next page of results, set the
        /// next request's "pageToken" value to this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration data for an Ad Exchange direct deal.</summary>
    public class DirectDeal : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The account id of the buyer this deal is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual System.Nullable<int> AccountId { get; set; } 

        /// <summary>The name of the advertiser this deal is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("advertiser")]
        public virtual string Advertiser { get; set; } 

        /// <summary>Whether the publisher for this deal is eligible for alcohol ads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowsAlcohol")]
        public virtual System.Nullable<bool> AllowsAlcohol { get; set; } 

        /// <summary>The account id that this deal was negotiated for. It is either the buyer or the client that this
        /// deal was negotiated on behalf of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buyerAccountId")]
        public virtual System.Nullable<long> BuyerAccountId { get; set; } 

        /// <summary>The currency code that applies to the fixed_cpm value. If not set then assumed to be USD.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currencyCode")]
        public virtual string CurrencyCode { get; set; } 

        /// <summary>The deal type such as programmatic reservation or fixed price and so on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dealTier")]
        public virtual string DealTier { get; set; } 

        /// <summary>End time for when this deal stops being active. If not set then this deal is valid until manually
        /// disabled by the publisher. In seconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual System.Nullable<long> EndTime { get; set; } 

        /// <summary>The fixed price for this direct deal. In cpm micros of currency according to currency_code. If set,
        /// then this deal is eligible for the fixed price tier of buying (highest priority, pay exactly the configured
        /// fixed price).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fixedCpm")]
        public virtual System.Nullable<long> FixedCpm { get; set; } 

        /// <summary>Deal id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual System.Nullable<long> Id { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Deal name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The minimum price for this direct deal. In cpm micros of currency according to currency_code. If
        /// set, then this deal is eligible for the private exchange tier of buying (below fixed price priority, run as
        /// a second price auction).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privateExchangeMinCpm")]
        public virtual System.Nullable<long> PrivateExchangeMinCpm { get; set; } 

        /// <summary>If true, the publisher has opted to have their blocks ignored when a creative is bid with for this
        /// deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publisherBlocksOverriden")]
        public virtual System.Nullable<bool> PublisherBlocksOverriden { get; set; } 

        /// <summary>The name of the publisher offering this direct deal.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sellerNetwork")]
        public virtual string SellerNetwork { get; set; } 

        /// <summary>Start time for when this deal becomes active. If not set then this deal is active immediately upon
        /// creation. In seconds since the epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual System.Nullable<long> StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A direct deals feed lists Direct Deals the Ad Exchange buyer account has access to. This includes
    /// direct deals set up for the buyer account as well as its merged stream seats.</summary>
    public class DirectDealsList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of direct deals relevant for your account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directDeals")]
        public virtual System.Collections.Generic.IList<DirectDeal> DirectDeals { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration data for an Ad Exchange performance report list.</summary>
    public class PerformanceReport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of bid responses with an ad.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRate")]
        public virtual System.Nullable<double> BidRate { get; set; } 

        /// <summary>The number of bid requests sent to your bidder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bidRequestRate")]
        public virtual System.Nullable<double> BidRequestRate { get; set; } 

        /// <summary>Rate of various prefiltering statuses per match. Please refer to the callout-status-codes.txt file
        /// for different statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("calloutStatusRate")]
        public virtual System.Collections.Generic.IList<object> CalloutStatusRate { get; set; } 

        /// <summary>Average QPS for cookie matcher operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cookieMatcherStatusRate")]
        public virtual System.Collections.Generic.IList<object> CookieMatcherStatusRate { get; set; } 

        /// <summary>Rate of ads with a given status. Please refer to the creative-status-codes.txt file for different
        /// statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeStatusRate")]
        public virtual System.Collections.Generic.IList<object> CreativeStatusRate { get; set; } 

        /// <summary>The number of bid responses that were filtered due to a policy violation or other errors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filteredBidRate")]
        public virtual System.Nullable<double> FilteredBidRate { get; set; } 

        /// <summary>Average QPS for hosted match operations.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hostedMatchStatusRate")]
        public virtual System.Collections.Generic.IList<object> HostedMatchStatusRate { get; set; } 

        /// <summary>The number of potential queries based on your pretargeting settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inventoryMatchRate")]
        public virtual System.Nullable<double> InventoryMatchRate { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The 50th percentile round trip latency(ms) as perceived from Google servers for the duration period
        /// covered by the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency50thPercentile")]
        public virtual System.Nullable<double> Latency50thPercentile { get; set; } 

        /// <summary>The 85th percentile round trip latency(ms) as perceived from Google servers for the duration period
        /// covered by the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency85thPercentile")]
        public virtual System.Nullable<double> Latency85thPercentile { get; set; } 

        /// <summary>The 95th percentile round trip latency(ms) as perceived from Google servers for the duration period
        /// covered by the report.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latency95thPercentile")]
        public virtual System.Nullable<double> Latency95thPercentile { get; set; } 

        /// <summary>Rate of various quota account statuses per quota check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("noQuotaInRegion")]
        public virtual System.Nullable<double> NoQuotaInRegion { get; set; } 

        /// <summary>Rate of various quota account statuses per quota check.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outOfQuota")]
        public virtual System.Nullable<double> OutOfQuota { get; set; } 

        /// <summary>Average QPS for pixel match requests from clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelMatchRequests")]
        public virtual System.Nullable<double> PixelMatchRequests { get; set; } 

        /// <summary>Average QPS for pixel match responses from clients.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pixelMatchResponses")]
        public virtual System.Nullable<double> PixelMatchResponses { get; set; } 

        /// <summary>The configured quota limits for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaConfiguredLimit")]
        public virtual System.Nullable<double> QuotaConfiguredLimit { get; set; } 

        /// <summary>The throttled quota limits for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quotaThrottledLimit")]
        public virtual System.Nullable<double> QuotaThrottledLimit { get; set; } 

        /// <summary>The trading location of this data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>The number of properly formed bid responses received by our servers within the deadline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("successfulRequestRate")]
        public virtual System.Nullable<double> SuccessfulRequestRate { get; set; } 

        /// <summary>The unix timestamp of the starting time of this performance data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual System.Nullable<long> Timestamp { get; set; } 

        /// <summary>The number of bid responses that were unsuccessful due to timeouts, incorrect formatting,
        /// etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unsuccessfulRequestRate")]
        public virtual System.Nullable<double> UnsuccessfulRequestRate { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The configuration data for an Ad Exchange performance report list.</summary>
    public class PerformanceReportList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>A list of performance reports relevant for the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("performanceReport")]
        public virtual System.Collections.Generic.IList<PerformanceReport> PerformanceReport { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class PretargetingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The id for billing purposes, provided for reference. Leave this field blank for insert requests;
        /// the id will be generated automatically.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("billingId")]
        public virtual System.Nullable<long> BillingId { get; set; } 

        /// <summary>The config id; generated automatically. Leave this field blank for insert requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configId")]
        public virtual System.Nullable<long> ConfigId { get; set; } 

        /// <summary>The name of the config. Must be unique. Required for all requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("configName")]
        public virtual string ConfigName { get; set; } 

        /// <summary>List must contain exactly one of PRETARGETING_CREATIVE_TYPE_HTML or
        /// PRETARGETING_CREATIVE_TYPE_VIDEO.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creativeType")]
        public virtual System.Collections.Generic.IList<string> CreativeType { get; set; } 

        /// <summary>Requests which allow one of these (width, height) pairs will match. All pairs must be supported ad
        /// dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<PretargetingConfig.DimensionsData> Dimensions { get; set; } 

        /// <summary>Requests with any of these content labels will not match. Values are from content-labels.txt in the
        /// downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedContentLabels")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedContentLabels { get; set; } 

        /// <summary>Requests containing any of these geo criteria ids will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedGeoCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedGeoCriteriaIds { get; set; } 

        /// <summary>Requests containing any of these placements will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPlacements")]
        public virtual System.Collections.Generic.IList<PretargetingConfig.ExcludedPlacementsData> ExcludedPlacements { get; set; } 

        /// <summary>Requests containing any of these users list ids will not match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedUserLists")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedUserLists { get; set; } 

        /// <summary>Requests containing any of these vertical ids will not match. Values are from the publisher-
        /// verticals.txt file in the downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedVerticals")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> ExcludedVerticals { get; set; } 

        /// <summary>Requests containing any of these geo criteria ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoCriteriaIds")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> GeoCriteriaIds { get; set; } 

        /// <summary>Whether this config is active. Required for all requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isActive")]
        public virtual System.Nullable<bool> IsActive { get; set; } 

        /// <summary>The kind of the resource, i.e. "adexchangebuyer#pretargetingConfig".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Request containing any of these language codes will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual System.Collections.Generic.IList<string> Languages { get; set; } 

        /// <summary>The maximum QPS allocated to this pretargeting configuration, used for pretargeting-level QPS
        /// limits. By default, this is not set, which indicates that there is no QPS limit at the configuration level
        /// (a global or account-level limit may still be imposed).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumQps")]
        public virtual System.Nullable<long> MaximumQps { get; set; } 

        /// <summary>Requests containing any of these mobile carrier ids will match. Values are from mobile-carriers.csv
        /// in the downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileCarriers")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileCarriers { get; set; } 

        /// <summary>Requests containing any of these mobile device ids will match. Values are from mobile-devices.csv
        /// in the downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileDevices")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileDevices { get; set; } 

        /// <summary>Requests containing any of these mobile operating system version ids will match. Values are from
        /// mobile-os.csv in the downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobileOperatingSystemVersions")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> MobileOperatingSystemVersions { get; set; } 

        /// <summary>Requests containing any of these placements will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("placements")]
        public virtual System.Collections.Generic.IList<PretargetingConfig.PlacementsData> Placements { get; set; } 

        /// <summary>Requests matching any of these platforms will match. Possible values are
        /// PRETARGETING_PLATFORM_MOBILE, PRETARGETING_PLATFORM_DESKTOP, and PRETARGETING_PLATFORM_TABLET.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platforms")]
        public virtual System.Collections.Generic.IList<string> Platforms { get; set; } 

        /// <summary>Creative attributes should be declared here if all creatives corresponding to this pretargeting
        /// configuration have that creative attribute. Values are from pretargetable-creative-attributes.txt in the
        /// downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportedCreativeAttributes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> SupportedCreativeAttributes { get; set; } 

        /// <summary>Requests containing any of these user list ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userLists")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> UserLists { get; set; } 

        /// <summary>Requests that allow any of these vendor ids will match. Values are from vendors.txt in the
        /// downloadable files section.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vendorTypes")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> VendorTypes { get; set; } 

        /// <summary>Requests containing any of these vertical ids will match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verticals")]
        public virtual System.Collections.Generic.IList<System.Nullable<long>> Verticals { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
        

        public class DimensionsData
        {
            /// <summary>Height in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("height")]
            public virtual System.Nullable<long> Height { get; set; } 

            /// <summary>Width in pixels.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("width")]
            public virtual System.Nullable<long> Width { get; set; } 

        }    

        public class ExcludedPlacementsData
        {
            /// <summary>The value of the placement. Interpretation depends on the placement type, e.g. URL for a site
            /// placement, channel name for a channel placement, app id for a mobile app placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("token")]
            public virtual string Token { get; set; } 

            /// <summary>The type of the placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

        }    

        public class PlacementsData
        {
            /// <summary>The value of the placement. Interpretation depends on the placement type, e.g. URL for a site
            /// placement, channel name for a channel placement, app id for a mobile app placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("token")]
            public virtual string Token { get; set; } 

            /// <summary>The type of the placement.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

        }
    }    

    public class PretargetingConfigList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of pretargeting configs</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<PretargetingConfig> Items { get; set; } 

        /// <summary>Resource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
