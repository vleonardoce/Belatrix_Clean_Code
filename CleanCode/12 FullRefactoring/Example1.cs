using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        private readonly PostRepository _postRepository;
        private readonly PostValidator _validator;
        public PostControl()
        {
            _postRepository = new PostRepository();
            _validator = new PostValidator();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack)
                TryToSavePost();
            else
                DisplayForm();
        }

        private void TryToSavePost()
        {
            Post post = MapPost();
            var results = ValidatePost(post);

            if (results.IsValid)
               _postRepository.SavePost(post);
            else
                DisplayErrors(results);
        }

        private void DisplayForm()
        {
            Post entity = _postRepository.GetPost(Convert.ToInt32(Request.QueryString["id"]));
            PostBody.Text = entity.Body;
            PostTitle.Text = entity.Title;
        }
         
        private void DisplayErrors(ValidationResult results)
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");

            foreach (var failure in results.Errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    summary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }

        private ValidationResult ValidatePost(Post post)
        {
            var results = _validator.Validate(post);
            return results;
        }

        private Post MapPost()
        {
            return new Post()
            {
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()

            };
        }

        public Label PostBody { get; set; }

        public Label PostTitle { get; set; }

        public int? PostId { get; set; }
    }

    #region helpers

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<ValidationError> Errors { get; set; }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostValidator
    {
        public ValidationResult Validate(Post entity)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

}