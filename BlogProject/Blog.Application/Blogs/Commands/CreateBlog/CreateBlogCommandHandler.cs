using AutoMapper;
using Blog.Application.Blogs.Queries.GetBlogs;
using Blog.Domain.Entity;
using Blog.Domain.IRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEnity = new MyBlog()
            {
                Name = request.Name,
                Description = request.Description,
                Author = request.Author,
                ImageUrl= request.ImageUrl,
            };
            var Result = await _blogRepository.CreateAsync(blogEnity);
            return _mapper.Map<BlogVm>(Result);
        }
    }
}
