       }
                    case GoogleBillingConnectionState.Disconnected:
                    {
                        var productDescriptionQuery = m_ProductsToQuery.Dequeue();
                        productDescriptionQuery.onRetrieveProductsFailed();

                        productsFailedToDequeue.Enqueue(productDescriptionQuery);
                        break;
                    }
                    case GoogleBillingConnectionState.Connecting:
                    {
                        stop = true;
                        break;
                    }
                    default:
                    {
                        Debug.LogErrorFormat("GooglePlayStoreService state ({0}) unrecognized, cannot process ProductDescriptionQuery",
                            m_GoogleConnectionState);
                        stop = true;
                        break;
                    }
                }
            }

            foreach (var product in productsFailedToDequeue)
            {
                m_ProductsToQuery.Enqueue(product);
            }
        }

        void DequeueFetchPurchases()
        {
            while (m_OnPurchaseSucceededQueue.Count > 0)
            {
                var onPurchaseSucceed = m_OnPurchaseSucceededQueue.Dequeue();
 