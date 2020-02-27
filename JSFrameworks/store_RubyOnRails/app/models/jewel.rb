class Jewel < ActiveRecord::Base
  belongs_to :collection
  validates :name, :description, :price, presence: true
  validates :name, length: { maximum: 20 }
  validates :description, length: { maximum: 500 }
  validates :price, numericality: { greater_than: 0,
                                    less_than: 1000000 }
end
