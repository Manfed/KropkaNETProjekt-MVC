﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizwanieMVCv2.QuizwanieService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/QuizwanieServiceV3.Model")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Points {
            get {
                return this.PointsField;
            }
            set {
                if ((this.PointsField.Equals(value) != true)) {
                    this.PointsField = value;
                    this.RaisePropertyChanged("Points");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role {
            get {
                return this.RoleField;
            }
            set {
                if ((object.ReferenceEquals(this.RoleField, value) != true)) {
                    this.RoleField = value;
                    this.RaisePropertyChanged("Role");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/QuizwanieServiceV3.Model")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorrectAnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WrongAnswer1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WrongAnswer2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WrongAnswer3Field;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CorrectAnswer {
            get {
                return this.CorrectAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.CorrectAnswerField, value) != true)) {
                    this.CorrectAnswerField = value;
                    this.RaisePropertyChanged("CorrectAnswer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WrongAnswer1 {
            get {
                return this.WrongAnswer1Field;
            }
            set {
                if ((object.ReferenceEquals(this.WrongAnswer1Field, value) != true)) {
                    this.WrongAnswer1Field = value;
                    this.RaisePropertyChanged("WrongAnswer1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WrongAnswer2 {
            get {
                return this.WrongAnswer2Field;
            }
            set {
                if ((object.ReferenceEquals(this.WrongAnswer2Field, value) != true)) {
                    this.WrongAnswer2Field = value;
                    this.RaisePropertyChanged("WrongAnswer2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WrongAnswer3 {
            get {
                return this.WrongAnswer3Field;
            }
            set {
                if ((object.ReferenceEquals(this.WrongAnswer3Field, value) != true)) {
                    this.WrongAnswer3Field = value;
                    this.RaisePropertyChanged("WrongAnswer3");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OngoingGame", Namespace="http://schemas.datacontract.org/2004/07/QuizwanieServiceV3.Model")]
    [System.SerializableAttribute()]
    public partial class OngoingGame : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallerUserAnswerCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CallerUserCorrectAnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsGameOverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OpponentAnswerCountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OpponentCorrectAnswersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OpponentUserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private QuizwanieMVCv2.QuizwanieService.Question[] QuestionsSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CallerUserAnswerCount {
            get {
                return this.CallerUserAnswerCountField;
            }
            set {
                if ((this.CallerUserAnswerCountField.Equals(value) != true)) {
                    this.CallerUserAnswerCountField = value;
                    this.RaisePropertyChanged("CallerUserAnswerCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CallerUserCorrectAnswers {
            get {
                return this.CallerUserCorrectAnswersField;
            }
            set {
                if ((this.CallerUserCorrectAnswersField.Equals(value) != true)) {
                    this.CallerUserCorrectAnswersField = value;
                    this.RaisePropertyChanged("CallerUserCorrectAnswers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsGameOver {
            get {
                return this.IsGameOverField;
            }
            set {
                if ((this.IsGameOverField.Equals(value) != true)) {
                    this.IsGameOverField = value;
                    this.RaisePropertyChanged("IsGameOver");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OpponentAnswerCount {
            get {
                return this.OpponentAnswerCountField;
            }
            set {
                if ((this.OpponentAnswerCountField.Equals(value) != true)) {
                    this.OpponentAnswerCountField = value;
                    this.RaisePropertyChanged("OpponentAnswerCount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OpponentCorrectAnswers {
            get {
                return this.OpponentCorrectAnswersField;
            }
            set {
                if ((this.OpponentCorrectAnswersField.Equals(value) != true)) {
                    this.OpponentCorrectAnswersField = value;
                    this.RaisePropertyChanged("OpponentCorrectAnswers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OpponentUserId {
            get {
                return this.OpponentUserIdField;
            }
            set {
                if ((this.OpponentUserIdField.Equals(value) != true)) {
                    this.OpponentUserIdField = value;
                    this.RaisePropertyChanged("OpponentUserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public QuizwanieMVCv2.QuizwanieService.Question[] QuestionsSet {
            get {
                return this.QuestionsSetField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionsSetField, value) != true)) {
                    this.QuestionsSetField = value;
                    this.RaisePropertyChanged("QuestionsSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuizwanieService.IQuizwanieService")]
    public interface IQuizwanieService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUser", ReplyAction="http://tempuri.org/IQuizwanieService/GetUserResponse")]
        QuizwanieMVCv2.QuizwanieService.User GetUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUser", ReplyAction="http://tempuri.org/IQuizwanieService/GetUserResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> GetUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/CreateUser", ReplyAction="http://tempuri.org/IQuizwanieService/CreateUserResponse")]
        QuizwanieMVCv2.QuizwanieService.User CreateUser(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/CreateUser", ReplyAction="http://tempuri.org/IQuizwanieService/CreateUserResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> CreateUserAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/ValidateUser", ReplyAction="http://tempuri.org/IQuizwanieService/ValidateUserResponse")]
        QuizwanieMVCv2.QuizwanieService.User ValidateUser(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/ValidateUser", ReplyAction="http://tempuri.org/IQuizwanieService/ValidateUserResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> ValidateUserAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/hashSha512", ReplyAction="http://tempuri.org/IQuizwanieService/hashSha512Response")]
        string hashSha512(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/hashSha512", ReplyAction="http://tempuri.org/IQuizwanieService/hashSha512Response")]
        System.Threading.Tasks.Task<string> hashSha512Async(string str);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/isGameInProgress", ReplyAction="http://tempuri.org/IQuizwanieService/isGameInProgressResponse")]
        bool isGameInProgress(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/isGameInProgress", ReplyAction="http://tempuri.org/IQuizwanieService/isGameInProgressResponse")]
        System.Threading.Tasks.Task<bool> isGameInProgressAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/startLookingForGame", ReplyAction="http://tempuri.org/IQuizwanieService/startLookingForGameResponse")]
        void startLookingForGame(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/startLookingForGame", ReplyAction="http://tempuri.org/IQuizwanieService/startLookingForGameResponse")]
        System.Threading.Tasks.Task startLookingForGameAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/getUsersRanking", ReplyAction="http://tempuri.org/IQuizwanieService/getUsersRankingResponse")]
        QuizwanieMVCv2.QuizwanieService.User[] getUsersRanking(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/getUsersRanking", ReplyAction="http://tempuri.org/IQuizwanieService/getUsersRankingResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User[]> getUsersRankingAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/isGameSearching", ReplyAction="http://tempuri.org/IQuizwanieService/isGameSearchingResponse")]
        bool isGameSearching(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/isGameSearching", ReplyAction="http://tempuri.org/IQuizwanieService/isGameSearchingResponse")]
        System.Threading.Tasks.Task<bool> isGameSearchingAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/AddQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/AddQuestionResponse")]
        bool AddQuestion(string name, string password, string content, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/AddQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/AddQuestionResponse")]
        System.Threading.Tasks.Task<bool> AddQuestionAsync(string name, string password, string content, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/AuthorizeQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/AuthorizeQuestionResponse")]
        bool AuthorizeQuestion(string userName, string password, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/AuthorizeQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/AuthorizeQuestionResponse")]
        System.Threading.Tasks.Task<bool> AuthorizeQuestionAsync(string userName, string password, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUnauthorizedQuestions", ReplyAction="http://tempuri.org/IQuizwanieService/GetUnauthorizedQuestionsResponse")]
        QuizwanieMVCv2.QuizwanieService.Question[] GetUnauthorizedQuestions(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUnauthorizedQuestions", ReplyAction="http://tempuri.org/IQuizwanieService/GetUnauthorizedQuestionsResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.Question[]> GetUnauthorizedQuestionsAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/DeleteUnauthorizeQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/DeleteUnauthorizeQuestionResponse")]
        void DeleteUnauthorizeQuestion(string userName, string password, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/DeleteUnauthorizeQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/DeleteUnauthorizeQuestionResponse")]
        System.Threading.Tasks.Task DeleteUnauthorizeQuestionAsync(string userName, string password, int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUserGames", ReplyAction="http://tempuri.org/IQuizwanieService/GetUserGamesResponse")]
        QuizwanieMVCv2.QuizwanieService.OngoingGame[] GetUserGames(string userName, string password, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetUserGames", ReplyAction="http://tempuri.org/IQuizwanieService/GetUserGamesResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.OngoingGame[]> GetUserGamesAsync(string userName, string password, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/CheckAnswer", ReplyAction="http://tempuri.org/IQuizwanieService/CheckAnswerResponse")]
        void CheckAnswer(int gameId, int questionId, int userId, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/CheckAnswer", ReplyAction="http://tempuri.org/IQuizwanieService/CheckAnswerResponse")]
        System.Threading.Tasks.Task CheckAnswerAsync(int gameId, int questionId, int userId, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetNextQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/GetNextQuestionResponse")]
        QuizwanieMVCv2.QuizwanieService.Question GetNextQuestion(int gameId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/GetNextQuestion", ReplyAction="http://tempuri.org/IQuizwanieService/GetNextQuestionResponse")]
        System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.Question> GetNextQuestionAsync(int gameId, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/fill", ReplyAction="http://tempuri.org/IQuizwanieService/fillResponse")]
        void fill();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuizwanieService/fill", ReplyAction="http://tempuri.org/IQuizwanieService/fillResponse")]
        System.Threading.Tasks.Task fillAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuizwanieServiceChannel : QuizwanieMVCv2.QuizwanieService.IQuizwanieService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuizwanieServiceClient : System.ServiceModel.ClientBase<QuizwanieMVCv2.QuizwanieService.IQuizwanieService>, QuizwanieMVCv2.QuizwanieService.IQuizwanieService {
        
        public QuizwanieServiceClient() {
        }
        
        public QuizwanieServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuizwanieServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuizwanieServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuizwanieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public QuizwanieMVCv2.QuizwanieService.User GetUser(int id) {
            return base.Channel.GetUser(id);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> GetUserAsync(int id) {
            return base.Channel.GetUserAsync(id);
        }
        
        public QuizwanieMVCv2.QuizwanieService.User CreateUser(string name, string password) {
            return base.Channel.CreateUser(name, password);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> CreateUserAsync(string name, string password) {
            return base.Channel.CreateUserAsync(name, password);
        }
        
        public QuizwanieMVCv2.QuizwanieService.User ValidateUser(string name, string password) {
            return base.Channel.ValidateUser(name, password);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User> ValidateUserAsync(string name, string password) {
            return base.Channel.ValidateUserAsync(name, password);
        }
        
        public string hashSha512(string str) {
            return base.Channel.hashSha512(str);
        }
        
        public System.Threading.Tasks.Task<string> hashSha512Async(string str) {
            return base.Channel.hashSha512Async(str);
        }
        
        public bool isGameInProgress(int userId) {
            return base.Channel.isGameInProgress(userId);
        }
        
        public System.Threading.Tasks.Task<bool> isGameInProgressAsync(int userId) {
            return base.Channel.isGameInProgressAsync(userId);
        }
        
        public void startLookingForGame(int userId) {
            base.Channel.startLookingForGame(userId);
        }
        
        public System.Threading.Tasks.Task startLookingForGameAsync(int userId) {
            return base.Channel.startLookingForGameAsync(userId);
        }
        
        public QuizwanieMVCv2.QuizwanieService.User[] getUsersRanking(string userName, string password) {
            return base.Channel.getUsersRanking(userName, password);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.User[]> getUsersRankingAsync(string userName, string password) {
            return base.Channel.getUsersRankingAsync(userName, password);
        }
        
        public bool isGameSearching(int userId) {
            return base.Channel.isGameSearching(userId);
        }
        
        public System.Threading.Tasks.Task<bool> isGameSearchingAsync(int userId) {
            return base.Channel.isGameSearchingAsync(userId);
        }
        
        public bool AddQuestion(string name, string password, string content, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3) {
            return base.Channel.AddQuestion(name, password, content, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
        }
        
        public System.Threading.Tasks.Task<bool> AddQuestionAsync(string name, string password, string content, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3) {
            return base.Channel.AddQuestionAsync(name, password, content, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3);
        }
        
        public bool AuthorizeQuestion(string userName, string password, int id) {
            return base.Channel.AuthorizeQuestion(userName, password, id);
        }
        
        public System.Threading.Tasks.Task<bool> AuthorizeQuestionAsync(string userName, string password, int id) {
            return base.Channel.AuthorizeQuestionAsync(userName, password, id);
        }
        
        public QuizwanieMVCv2.QuizwanieService.Question[] GetUnauthorizedQuestions(string userName, string password) {
            return base.Channel.GetUnauthorizedQuestions(userName, password);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.Question[]> GetUnauthorizedQuestionsAsync(string userName, string password) {
            return base.Channel.GetUnauthorizedQuestionsAsync(userName, password);
        }
        
        public void DeleteUnauthorizeQuestion(string userName, string password, int id) {
            base.Channel.DeleteUnauthorizeQuestion(userName, password, id);
        }
        
        public System.Threading.Tasks.Task DeleteUnauthorizeQuestionAsync(string userName, string password, int id) {
            return base.Channel.DeleteUnauthorizeQuestionAsync(userName, password, id);
        }
        
        public QuizwanieMVCv2.QuizwanieService.OngoingGame[] GetUserGames(string userName, string password, int userId) {
            return base.Channel.GetUserGames(userName, password, userId);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.OngoingGame[]> GetUserGamesAsync(string userName, string password, int userId) {
            return base.Channel.GetUserGamesAsync(userName, password, userId);
        }
        
        public void CheckAnswer(int gameId, int questionId, int userId, string answer) {
            base.Channel.CheckAnswer(gameId, questionId, userId, answer);
        }
        
        public System.Threading.Tasks.Task CheckAnswerAsync(int gameId, int questionId, int userId, string answer) {
            return base.Channel.CheckAnswerAsync(gameId, questionId, userId, answer);
        }
        
        public QuizwanieMVCv2.QuizwanieService.Question GetNextQuestion(int gameId, int userId) {
            return base.Channel.GetNextQuestion(gameId, userId);
        }
        
        public System.Threading.Tasks.Task<QuizwanieMVCv2.QuizwanieService.Question> GetNextQuestionAsync(int gameId, int userId) {
            return base.Channel.GetNextQuestionAsync(gameId, userId);
        }
        
        public void fill() {
            base.Channel.fill();
        }
        
        public System.Threading.Tasks.Task fillAsync() {
            return base.Channel.fillAsync();
        }
    }
}
