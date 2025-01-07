﻿using Divarche.Domain.Core.Entities.BaseEntities;
using Divarche.Domain.Core.Enum;

namespace Divarche.Domain.Core.Entities.Advertisement;
public class Advertisement
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Model { get; set; }
    public int VisitCount { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime ApprovedAt { get; set; }
    public AdvertisementTypeEnum AdvertisementType { get; set; }
    public AdvertisementStatusEnum AdvertisementStatus { get; set; }
    public AdvertisementFinalStatusEnum AdvertisementFinalStatus { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public int CityId { get; set; }
    public int BrandId { get; set; }
    #endregion
    #region NavigationProperties

    public List<Image> Images { get; set; }
    public User.User User { get; set; }
    public List<User.User> UserFavoriteAdvertisments { get; set; }
    public Category Category { get; set; }
    public City City { get; set; }
    public Brand Brand { get; set; }

    #endregion
}

public class Brand
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    #endregion

    #region NavigationProperties
    public List<Advertisement> Advertisements { get; set; }
    #endregion
}