using System;
using Dynamo.Graph.Workspaces;
using Dynamo.Models;


namespace DynamoForceUpdater
{
    public static class ForceUpdater
    {
        private static WorkspaceModel currentWorkspace;
        private static DynamoModel dynModel;


        public static dynamic Update(dynamic anything)
        {
            
            Dynamo.Applications.DynamoRevit dynamoRevit = new Dynamo.Applications.DynamoRevit();
            currentWorkspace = GetCurrentWorkspace();
            dynModel = Dynamo.Applications.DynamoRevit.RevitDynamoModel;
            dynModel.EvaluationCompleted += new EventHandler<EvaluationCompletedEventArgs>(onEvaluationCompleted);


            return anything;
        }

        private static void onEvaluationCompleted(object sender, EvaluationCompletedEventArgs e)
        {
            foreach (var node in currentWorkspace.Nodes)
            {
                
                if (node.Name.Contains("ForceUpdater"))
                {
                    var connectors = node.OutPorts[0].Connectors;
                    foreach (var connector in connectors)
                    {
                        connector.End.Owner.MarkNodeAsModified(true);
                    }
                    //node.MarkNodeAsModified(true);
                }
            }
        }

        private static WorkspaceModel GetCurrentWorkspace()
        {
            var model = Dynamo.Applications.DynamoRevit.RevitDynamoModel;
           WorkspaceModel ws = model.CurrentWorkspace;
            return ws;
        }


    }
}
